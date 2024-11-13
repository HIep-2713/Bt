using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnigthBlock : MonoBehaviour
{
    public Animator ani;
    public Rigidbody2D rb;
    private bool block;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad0))
        {
            Debug.Log("Block");
            ani.SetBool("Block", block);
            Block();
        }
    }
    void Block()
    {
        ani.SetTrigger("Block");
    }
}
