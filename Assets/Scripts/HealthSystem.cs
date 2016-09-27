using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
    [SerializeField]
    private float _lifes = 3;

	
    void OnTriggerEnter2D (Collider2D other)
    {
        if (_lifes <= 0)
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Obstacle"))
        {
            _lifes -= 1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Water"))
        {
            _lifes -= 1;
        }
    }
}
