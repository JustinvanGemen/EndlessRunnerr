using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float jump = 400;
    private bool isGrounded = true;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1, 1 << LayerMask.NameToLayer("Platform"));
        if (gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
            {
                rigidBody.AddForce(Vector2.up * jump);
                isGrounded = false;
            }
        }
        else if (gameObject.CompareTag("Player2"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(5f * Time.deltaTime, 0f, 0f);
            }
            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                rigidBody.AddForce(Vector2.up * jump);
                isGrounded = false;
            }
        }
        
    }
}
