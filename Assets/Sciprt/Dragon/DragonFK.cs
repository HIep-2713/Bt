using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFK : MonoBehaviour
{
    private bool isButtonPressed = false;
    private float buttonPressTime;
    private float doubleClickTime = 0.2f; // Khoảng thời gian tối đa giữa hai lần nhấn
    public Rigidbody2D rb;
    public Animator ani;
    private bool flykick;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // Thay KeyCode.Space bằng nút mong muốn
        {
            if (!isButtonPressed)
            {
                isButtonPressed = true;
                buttonPressTime = Time.time;
            }
            else if (Time.time - buttonPressTime <= doubleClickTime)
            {
                // Thực hiện hành động khi nhấn đúp
                Debug.Log("Nhấn đúp!");
                isButtonPressed = false;
                ani.SetTrigger("FlyKick");
                
            }
            else
            {
                isButtonPressed = false;
                ani.SetBool("FlyKick",flykick);
            }
        }
    }
    
}
