using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
    }
    }
