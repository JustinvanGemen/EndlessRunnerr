using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float jump = 400;
    private bool isGrounded = true;
    private bool waitOnJump = true;
    [SerializeField]
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1, 1 << LayerMask.NameToLayer("Platform"));
        if (gameObject.CompareTag("Player2"))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
                anim.SetBool("walk", true);
            }
            if (Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.UpArrow) == false)
            {
                anim.SetBool("walk", false);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded && waitOnJump)
            {
                anim.SetTrigger("jump");
                rigidBody.AddForce(Vector2.up * jump);
                isGrounded = false;
                waitOnJump = false;
                Invoke("WaitOnJump", 0.1f);
                
            }
        }
        else if (gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
                anim.SetBool("walk", true);
            }
            if (Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.D) == false)
            {
                anim.SetBool("walk", false);

            }

            if (Input.GetKeyDown(KeyCode.W) && isGrounded && waitOnJump)
            {
                anim.SetTrigger("jump");
                rigidBody.AddForce(Vector2.up * jump);
                isGrounded = false;
                waitOnJump = false;
                Invoke("WaitOnJump", 0.1f);
                
            }
        }
        
    }
    private void WaitOnJump()
    {
        waitOnJump = true;
    }
}
