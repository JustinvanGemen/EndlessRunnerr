using UnityEngine;
using System.Collections;

public class ObstacleSpawning : MonoBehaviour {
    [SerializeField] //lets the var be able to get changed in the editor while private.
    private GameObject[] obstacleField; //make an array of gameObjects for the Obstacle fields avaidable.
    private Vector3 OFSize = new Vector3(50, 0, 0); //make a new vector3 in the x size of the object fields.


    //10
    void OnBecameInvisible() //when a gameobject with this script gets out of sight start this function.
    {
        int randomBackground = Random.Range(0, obstacleField.Length); //make a new int that has a random number from 0 to 3 (4 never gets chosen).
        SpawnObstacle(randomBackground);
    }

    private void SpawnObstacle(int i)
    {
        transform.position += OFSize;
        obstacleField[i].transform.position = transform.position; //move the backgrounds to the game object.
        GameObject go = Instantiate(obstacleField[i]);
        go.transform.position = new Vector3(this.transform.position.x, 1.2f, 0) ;
    }
}
