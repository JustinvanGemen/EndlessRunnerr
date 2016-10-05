using UnityEngine;
using System.Collections;
//joey vd Wijk
public class PlayerIgnore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics2D.IgnoreLayerCollision(9, 9);
	}
}
