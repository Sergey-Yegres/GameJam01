using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        isRun();
        isRunDown();
        isRunUp();
    }
    void isRun()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isRunDown", false);
            anim.SetBool("isRunUp", false);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
    void isRunDown()
    {
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunDown", true);
            anim.SetBool("isRunUp", false);
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunDown", false);
        }
    }
    void isRunUp()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isRunUp", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isRunDown", false);
        }
        else
        {
            anim.SetBool("isRunUp", false);
        }
    }
}
