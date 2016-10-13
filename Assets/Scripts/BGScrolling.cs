using UnityEngine;
using System.Collections;
//Joey vd Wijk
public class BGScrolling : MonoBehaviour {
    [SerializeField] //lets the var be able to get changed in the editor while private.
    private GameObject[] backgrounds; //make an array of gameObjects for the backgrounds avaidable.
    private Vector3 BGSize = new Vector3(35.4f, 0, 0); //make a new vector3 in the x size of the backgrounds.
 

    //10
    void OnBecameInvisible() //when a gameobject with this script gets out of sight start this function.
    {
        Debug.Log("ag");
        int randomBackground = Random.Range(0, 4); //make a new int that has a random number from 0 to 3 (4 never gets chosen).
        transform.position += BGSize; //move the gameObject to the end of the screen.
        backgrounds[randomBackground].transform.position = transform.position; //move the backgrounds to the game object.
    }
}

