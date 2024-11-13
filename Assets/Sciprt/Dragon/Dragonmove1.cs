using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.InputSystem;

public class Dragonmove1 : MonoBehaviour

{
   
    public float move;
    public Animator ani;
    public float speed = 10f;
    public Rigidbody2D rd;
    private bool isFacingRight = true;
    
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            move = -1;
            Debug.Log("dragon left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1;
            Debug.Log("dragon move right");
        }
        else
        {
            move = 0;
            Debug.Log("Dragon idie");
        }
        transform.Translate(Vector3.right * move * speed * Time.deltaTime);        
        if (move > 0 && !isFacingRight)
        {
            Flip();
        }
        else if(move < 0 && isFacingRight)
        {
            Flip();
        }
        ani.SetFloat("walk1", Mathf.Abs(move));
       
       
        

    }
    
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,transform.localScale.z);
        
    }
    

}
