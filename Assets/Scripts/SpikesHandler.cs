using UnityEngine;
using System.Collections;

public class SpikesHandler : MonoBehaviour {
    [SerializeField]
    private GameObject[] spikes;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            spikes[0].gameObject.SetActive(false);
            spikes[1].gameObject.SetActive(true);
        }
    }
}
