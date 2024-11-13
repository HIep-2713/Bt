using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Knigthmove : MonoBehaviour

{
    private bool isFacingRight = true;
    public float move;
    public float speed = 10f;
    private Animator ani;
    public Rigidbody2D rd;
    

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = -1;
            Debug.Log("left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move = 1;
            Debug.Log("right");
        }
        else
        {
            move = 0;
            Debug.Log("idie");
        }
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);

        if (move > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (move < 0 && isFacingRight)
        {
            Flip();
        }
        ani.SetFloat("walk", Mathf.Abs(move));


        void Flip()
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,
     transform.localScale.z);
        }



    }
}

