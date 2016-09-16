using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

    private float lifes = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (lifes <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerHit(Collision other)
    {
        if (CompareTag("Obstacle"))
        {
            lifes = lifes - 1;
            Destroy(other.gameObject);
        }
    }
}
