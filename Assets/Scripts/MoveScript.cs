using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
    }
}
