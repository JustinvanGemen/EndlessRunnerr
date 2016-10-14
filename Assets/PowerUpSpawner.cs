using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject[] powerUps;
    private int randomNumber;
    private Vector3 vec3;
	// Use this for initialization
	void Start () {
        vec3 = new Vector3(transform.position.x, transform.position.y, 0);
        randomNumber = Random.Range(0, powerUps.Length);
        Debug.Log(randomNumber);
        GameObject obj = Instantiate(powerUps[randomNumber]);
        obj.transform.position = transform.position;
        
	}
}
