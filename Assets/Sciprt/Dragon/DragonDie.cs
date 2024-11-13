using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonDie : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    private bool die;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            Debug.Log("Die");
            animator.SetBool("Die", die);
            Die();
        }
    }
    void Die()
    {
        animator.SetTrigger("Die");
        
    }
    
}
