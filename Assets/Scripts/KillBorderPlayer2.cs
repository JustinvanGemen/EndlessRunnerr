using UnityEngine;
using System.Collections;

public class KillBorderPlayer2 : MonoBehaviour {

    [SerializeField]
    private GameObject _otherPlayer;
    private HealthSystem _hSys;
    private Vector3 _thisPlayer3;

    void Start()
    {
        _thisPlayer3 = transform.position;
        _hSys = this.GetComponent<HealthSystem>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("CamKill"))
        {
            _hSys.lifes -= 1f;
            _thisPlayer3.x = _thisPlayer3.x + 9;
            _thisPlayer3.y = 4;
            transform.position = _thisPlayer3;
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        Debug.Log(transform.position.x);
        yield return null;
    }


    }
