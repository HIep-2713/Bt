using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragoncrouch : MonoBehaviour
{
    public Animator ani;
    public Rigidbody2D rb;
    private bool crouch;


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();    
        ani = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log("Crouch");
            ani.SetBool("Crouch", crouch);
            Crouch();
        }
    }
    void Crouch()
    {
        ani.SetTrigger("Crouch");
    }
}
