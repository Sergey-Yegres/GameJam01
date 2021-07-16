using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PlayerController;


public class WallController : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public int damage = 3;
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(direction.normalized * speed);
    }
}