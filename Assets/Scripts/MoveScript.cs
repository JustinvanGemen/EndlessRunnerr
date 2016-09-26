using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float jump = 400;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up * jump);

        }
    }
}
