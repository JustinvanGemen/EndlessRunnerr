﻿using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    private float _timeToMove = 0.1F;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        MoveRight();
    }
    private void MoveRight()
    {
        if (Time.time > _timeToMove)
        {
            Vector3 position = this.transform.position;
            position.x +=2;
            this.transform.position = position;
            _timeToMove = 0.2f + Time.time;
        }
    }
}