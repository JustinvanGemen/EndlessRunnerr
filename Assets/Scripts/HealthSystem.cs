using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
    [SerializeField]
    private float _lifes = 3;
	
	// Update is called once per frame
	void Update () {
	    if (_lifes <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D   (Collider2D other)
    {
        Debug.Log("hi");    
        if (other.CompareTag("Obstacle"))
        {
            _lifes -= 1;
            Destroy(other.gameObject);
        }
    }
}
