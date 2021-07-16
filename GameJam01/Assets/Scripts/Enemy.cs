using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player; // Переменная для координат игрока
    public float speed;
    public void Start()
    {
        player = GameObject.Find("Player").transform;

    }

    public void FixedUpdate()
    {
        enemyWalk();
    }
    void enemyWalk()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "Sword")
        {
            
            Destroy(gameObject);
            
            
        }
    }
}
