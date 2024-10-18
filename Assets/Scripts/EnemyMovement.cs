using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float enemySpeed = 2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = (Player.position - transform.position).normalized;
        rb.MovePosition(rb.position + direction * enemySpeed * Time.fixedDeltaTime);
    }
}
