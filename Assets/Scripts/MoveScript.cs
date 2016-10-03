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

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidBody.AddForce(Vector2.up * jump);
            isGrounded = false;
        }
    }
}
