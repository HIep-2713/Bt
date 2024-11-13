using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    public Animator ani;
    public Rigidbody2D rb;
    private bool attack;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            Debug.Log("Attack");
            ani.SetBool("Attack", attack);
            Attack();
            
            
        }
    }
    void Attack()
    {
        ani.SetTrigger("Attack");
       
    }
}
