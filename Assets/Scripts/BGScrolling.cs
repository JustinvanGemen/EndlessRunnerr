using UnityEngine;
using System.Collections;

public class BGScrolling : MonoBehaviour {
    [SerializeField]
    private GameObject[] backgrounds;
    private Vector3 BGSize = new Vector3(35.4f, 0, 0);
    //bg = 1280, 70 * 1,4

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //19
    void OnBecameInvisible()
    {
        int randomBackground = Random.Range(0, 4);
        transform.position += BGSize;
        backgrounds[randomBackground].transform.position = transform.position;
    }
}
