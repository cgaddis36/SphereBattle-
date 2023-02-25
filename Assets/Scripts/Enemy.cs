using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float speed = 3.0f;
    private Rigidbody enemyRigidbody;

    void Start()
    {
        player = GameObject.Find("Player");
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 enemyPosition = transform.position;
        Vector3 lookDirection = (playerPosition - enemyPosition).normalized;
        enemyRigidbody.AddForce(lookDirection * speed);
    }
}
