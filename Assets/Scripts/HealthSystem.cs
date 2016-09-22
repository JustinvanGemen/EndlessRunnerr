using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
    [SerializeField]
    private float _lifes = 3;
    private float _waterTimer = 3f;
	
	// Update is called once per frame
	void Update () {
        if (_waterTimer > 0)
        {
            _waterTimer--;
        }

        if (_lifes <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D   (Collider2D other)
    {
        
   
        if (other.CompareTag("Obstacle"))
        {
            _lifes -= 1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Water") && _waterTimer == 0)
        {
            _lifes -= 1;
            _waterTimer = 3;
        }
    }
}
