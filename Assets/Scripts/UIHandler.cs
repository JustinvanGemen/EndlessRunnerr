using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {
    [SerializeField]
    private Text score;
    [SerializeField]
    private Text LifeScore;
    private float lifes;
    private HealthSystem healthSystem;
    private float startPos;

    void Start()
    {
        startPos = transform.position.x;
        healthSystem = GetComponent<HealthSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        LifeScore.text = "Lifes: " + healthSystem.lifes;
        score.text = "Score: " + (transform.position.x - startPos);
	}
}
