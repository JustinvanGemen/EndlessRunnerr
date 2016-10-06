using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    private float speed;
	// Use this for initialization
	void Start () {
        speed = 3f;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        //}
    }
    }
