using UnityEngine;
using System.Collections;
//Joey vd Wijk

    /// <summary>
    /// This script lets you enable and disable the spikes linked to the script.
    /// </summary>
public class SpikesActivator : MonoBehaviour {

    [SerializeField]
    private GameObject[] spikes; //make an array of gameobjects named spikpes.

    void OnTriggerEnter2D(Collider2D other) { //if gameobject gets hit by a player
        if (other.CompareTag("Player") || other.CompareTag("Player2")) {
            spikes[0].gameObject.SetActive(false); //disable spikes[0]
            spikes[1].gameObject.SetActive(true); //enable spikes[1]
        }
    }
}
