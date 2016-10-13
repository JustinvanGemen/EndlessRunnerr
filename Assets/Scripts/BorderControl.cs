using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

    [SerializeField]
    private GameObject _otherPlayer;
    [SerializeField]
    private GameObject _camera;
    private CameraMovement _camMove;
    private float _camSpeed;
    private bool fast;
    private bool slow;

	void Start () {
        
        _camMove = _camera.GetComponent<CameraMovement>();
    }
	
	void OnTriggerStay2D(Collider2D other) {
	    if (_otherPlayer.transform.position.x < transform.position.x)
        {
            
            if (other.CompareTag("CamFast"))
            {
                fast = true;
                _camMove.speed = 3.1f;
                StartCoroutine(Timer());
            }
            if(other.CompareTag("CamSlow"))
                {
                slow = true;
                _camMove.speed = 2.9f;
                StartCoroutine(Timer());
            }
           
        }
	}

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        if (fast)
        {
            _camMove.speed = 3;
            fast = false;
        }
        if (slow)
        {
            _camMove.speed = 3;
            slow = false;
        }
    }

}
