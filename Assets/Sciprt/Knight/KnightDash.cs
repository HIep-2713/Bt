using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class KnightDash : MonoBehaviour
{
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    [SerializeField] private TrailRenderer tr;
    public Rigidbody2D rb;
    public Animator ani;
    private bool dash;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void Update()
    {
        if (isDashing)
        {
            return;
        }


        if (Input.GetKey(KeyCode.RightShift) && canDash)
        {
            StartCoroutine(Dash());
            ani.SetBool("Dash", dash);
            Strike();
        }
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
    void Strike()
    {
        ani.SetTrigger("Dash");
    }
}
