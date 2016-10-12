using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    private float _speed;
    public float speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }
	// Use this for initialization
	void Start () {
        _speed = 3f;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > 2)
        {
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
        }
    }
    }
