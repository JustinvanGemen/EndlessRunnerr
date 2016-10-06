using UnityEngine;
using System.Collections;

public class UpAndDown : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float maxHeight;
    private float minHeight;

	// Use this for initialization
	void Start () {
        speed = Random.Range(4,10);
        maxHeight = transform.position.y + 5;
        minHeight = transform.position.y - 5;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(0, speed * Time.deltaTime, 0);
        if (transform.position.y >= maxHeight || transform.position.y <= minHeight)
        {
            speed = speed * -1;
        }
	}
}
