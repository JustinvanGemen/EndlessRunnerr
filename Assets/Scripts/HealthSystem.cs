using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

    private float _lifes = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (_lifes <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerHit(Collision other)
    {
        if (CompareTag("Obstacle"))
        {
            _lifes = _lifes - 1;
            Destroy(other.gameObject);
        }
    }
}
