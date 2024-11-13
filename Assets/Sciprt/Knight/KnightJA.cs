using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightJA : MonoBehaviour
{
    private bool button1 = false;
    private bool button2 = false;
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
        if (Input.GetKeyDown(KeyCode.UpArrow)) // Nút 1
        {
            button1 = true;
            button1PressTime = Time.time;
        }

        if (Input.GetKeyDown(KeyCode.Keypad1)) // Nút 2
        {
            button2 = true;
            if (button1 && Time.time - button1PressTime <= doubleKeyPressTime)
            {
                ani.SetTrigger("JumpAttack"); // Trigger animation thứ 3
                button1 = false;
                button2 = false;
            }
            else
            {
                button2 = false; // Reset nếu không phải là tổ hợp phím đúng
                ani.SetBool("JumpAttack", jumpattack);
            }
        }

        // Reset button1Pressed nếu quá thời gian cho phép
        if (button1 && Time.time - button1PressTime > doubleKeyPressTime)
        {
            button1 = false;
        }

    }
}
