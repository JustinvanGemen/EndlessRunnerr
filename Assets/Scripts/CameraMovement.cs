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
        Time.timeScale = 1;
        _speed = 3f;
        speed = 3f;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > 2)
        {
            transform.Translate(_speed * Time.deltaTime, 0f, 0f);
            // 3 * ~1, 0, 0
            // 3(-0.1) * ~1, 0, 0
            // 3(+0.1) * ~1, 0, 0
        }
    }
    }
