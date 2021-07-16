using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public Vector3 MousePos;
    public Vector2 speed;

    private void Update()
    {
        swordDirection();
    }
    private void FixedUpdate()
    {
        swordMovement();
    }
    void swordDirection()//направление меча
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
    }
    void swordMovement()
    {
        transform.Translate(speed * Time.deltaTime);
    }
    }
