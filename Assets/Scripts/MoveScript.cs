using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField]
    private float jump = 400;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * jump * Time.deltaTime);

        }
    }
}
