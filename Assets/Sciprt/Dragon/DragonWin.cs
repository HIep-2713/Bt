using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonWin : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Animator ani;
    private bool win;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.U))
        {
            Debug.Log("WIn");
            ani.SetBool("WIn", win);
            Win();
        }
    }
    void Win()
    {
        ani.SetTrigger("Win");
    }
}
