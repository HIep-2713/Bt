using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpKnight : MonoBehaviour
{
    public Rigidbody2D rd;
    public Animator anitor;
    private bool grounded;
    public float Jumphigh;
    private float speed = 10f;
    private float move;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        anitor = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && grounded)
            Jump();
        anitor.SetBool("grounded", grounded);
    }
    private void Jump()
    {
        rd.velocity = new Vector2(rd.velocity.x, speed);
        anitor.SetTrigger("Jump");
        grounded = false;
        rd.AddForce((Vector2.up) * Jumphigh);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
