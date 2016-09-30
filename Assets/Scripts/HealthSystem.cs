using UnityEngine;
using System.Collections;
//Joey vd Wijk
public class HealthSystem : MonoBehaviour {
    [SerializeField] 
    private float _lifes = 3; //make a float for the players life, give him 3. (if you want you can change it in the editor)

	
    void OnTriggerEnter2D (Collider2D other) //if something that has trigger enabled, hits the player
    {
        if (_lifes <= 0) //if player runs out of lifes destroy him.
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Obstacle")) //if player hits an obstacle destroy the obstacle and remove a life from the player.
        {
            _lifes -= 1;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Water"))
        {
            _lifes -= 1;
        }
    }
}
