using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int health;
    public float speed = 0.1f;
    public bool flip = false;
    public Image[] hearts;
    public Sprite fullHearth;
    public Sprite lostHearth;
    public Vector3 playerPosition;
    void Update()
    {
        Move();
        Flip();
        showHealth();
        PlayerDie();
    }
    void Move()
    {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");  
        transform.position += new Vector3(0, speed, 0) * Input.GetAxis("Vertical");   
    }
    void showHealth()
    {
        for(int i = 0; i< hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHearth;
            }
            else
            {
                hearts[i].sprite = lostHearth;
            }
        }
    }
    void Flip()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Wall")
        {
            takeDamage(3);
        }
        if (collider.gameObject.tag == "Enemy")
        {
            takeDamage(1);
        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
    }
    public void PlayerDie()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
