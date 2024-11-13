using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JADragon : MonoBehaviour
{
    private bool button1Pressed = false;
    private bool button2Pressed = false;
    private float button1PressTime;
    private float doubleKeyPressTime = 0.2f; // Khoảng thời gian tối đa giữa hai lần nhấn
    public Rigidbody2D rb;
    public Animator ani;
    private bool jumpattack;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // Nút 1
        {
            button1Pressed = true;
            button1PressTime = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.J)) // Nút 2
        {
            button2Pressed = true;
            if (button1Pressed && Time.time - button1PressTime <= doubleKeyPressTime)
            {
                ani.SetTrigger("JumpAttack"); // Trigger animation thứ 3
                button1Pressed = false;
                button2Pressed = false;
            }
            else
            {
                button2Pressed = false; // Reset nếu không phải là tổ hợp phím đúng
                ani.SetBool("FlyKick",jumpattack);
            }
        }

        // Reset button1Pressed nếu quá thời gian cho phép
        if (button1Pressed && Time.time - button1PressTime > doubleKeyPressTime)
        {
            button1Pressed = false;
        }

    }
    }
