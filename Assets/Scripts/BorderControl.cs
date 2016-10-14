using UnityEngine;
using System.Collections;

public class BorderControl : MonoBehaviour {

    [SerializeField]
    private GameObject _otherPlayer;
    [SerializeField]
    private GameObject _camera;
    private CameraMovement _camMove;
    private HealthSystem _hSys;
    private float _camSpeed;
    private bool _fast;
    private bool _slow;
    private float _teleport;
    private Vector3 _thisPlayer3;


    void Start () {
        _thisPlayer3 = transform.position;
        _camMove = _camera.GetComponent<CameraMovement>();
        _hSys = this.GetComponent<HealthSystem>();
    }

    void update()
    {
        _thisPlayer3 = transform.position;
    }
	
	void OnTriggerStay2D(Collider2D other) {
	    if (_otherPlayer.transform.position.x < transform.position.x)
        {
            
            if (other.CompareTag("CamFast"))
            {
                _fast = true;
                _camMove.speed = 5f;
                StartCoroutine(Timer());
                Debug.Log("Fast");
            }
            if(other.CompareTag("CamSlow"))
                {
                _slow = true;
                _camMove.speed = 1.5f;
                StartCoroutine(Timer());
                Debug.Log("Slow");
            }
        }

        if (other.CompareTag("CamKill"))
        {
            Debug.Log("Life lost wall");
            _hSys.lifes -= 1f;
            _teleport = _otherPlayer.transform.position.x - transform.position.x;
            _thisPlayer3.x += 9;
            _thisPlayer3.y = 4;
            transform.position = _thisPlayer3;

        }

    }



    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        if (_fast)
        {
            _camMove.speed = 3;
            _fast = false;
            Debug.Log("FastEnd");
        }
        if (_slow)
        {
            _camMove.speed = 3;
            _slow = false;
            Debug.Log("SlowEnd");
        }
    }

}
