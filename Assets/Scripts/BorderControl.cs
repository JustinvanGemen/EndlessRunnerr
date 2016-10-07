using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

    [SerializeField]
    private GameObject _otherPlayer;

	void Start () {
        Debug.Log(_otherPlayer.transform.position.x);
    }
	
	void OnTriggerStay2D(Collider2D other) {
	    if (_otherPlayer.transform.position.x < transform.position.x)
        {
            
            if (transform.position.x > Camera.main.transform.position.x)
            {
                Debug.Log("jkhjfeg");
            }
        }
	}
}
