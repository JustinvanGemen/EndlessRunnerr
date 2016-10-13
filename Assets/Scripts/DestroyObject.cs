using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	void OnBecameInvisible()
    {
        Debug.Log("sdg");
        Destroy(gameObject);
    }
}
