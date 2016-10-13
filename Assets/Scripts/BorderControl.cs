using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

    [SerializeField]
    private GameObject _otherPlayer;
    [SerializeField]
    private GameObject _camera;
    private CameraMovement _camMove;
    private float _camSpeed;

	void Start () {
        
        _camMove = _camera.GetComponent<CameraMovement>();
    }
	
	void OnTriggerStay2D(Collider2D other) {
	    if (_otherPlayer.transform.position.x < transform.position.x)
        {
            
            if (other.CompareTag("CamFast"))
            {
                _camMove.speed = _camMove.speed + 0.1f;
                //Invoke("CamMov", 1);
            }
           
        }
	}

    void CamMov()
    {
        _camMove.speed = _camMove.speed * 1;
    }

}
