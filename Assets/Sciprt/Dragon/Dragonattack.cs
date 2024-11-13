using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dragonattack : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D Rb;
    private bool attack = false;
    public Transform Shooting;
    public GameObject ShootingPrefab;
    public Transform FirePoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, FirePoint.position, transform.rotation);
            animator.SetBool("Attack", attack);
            Attack();
        }
        //if (Input.GetKey(KeyCode.J))
       // {
           // Debug.Log("Attack");
           // animator.SetBool("Attack", attack);
             //  Attack();
        //}

    }
    void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
