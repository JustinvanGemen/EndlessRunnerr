using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Joey vd Wijk
public class UIUpdater : MonoBehaviour {
    [SerializeField]
    private Text score;
    [SerializeField]
    private Text LifeScore;
    private float lifes;
    private HealthSystem healthSystem;
    private float lastPos;
    private float scorePoints;
    private int multiplier = 1;

    public float ScorePoints
    {
        get
        {
            return scorePoints;
        }
    }

    void Start()
    {
        //lastPos = transform.position.x;
        healthSystem = GetComponent<HealthSystem>();
        InvokeRepeating("ScoreUpdate", 0.1f , 0.1f);
    }
	
	// Update is called once per frame
	void Update () {        
        LifeScore.text = "Lifes: " + healthSystem.lifes;
        score.text = "Score: " + Mathf.Round(scorePoints);
	}

    private void ScoreUpdate()
    {
        scorePoints = scorePoints + ((transform.position.x - lastPos) * multiplier);
        lastPos = transform.position.x;
    }
    private void ReturnMultiplier()
    {

        multiplier = 1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "ScoreBoost")
        {
            scorePoints = scorePoints + 20;
            Destroy(other.gameObject);
        }
        else if(other.name == "ScoreMultiplier")
        {
            multiplier = 2;
            Invoke("ReturnMultiplier", 3);
            Destroy(other.gameObject);
        }
        else if(other.name == "PointsDebuff")
        {
            scorePoints = scorePoints - 10;
            Destroy(other.gameObject);
        }
        else if(other.name == "ScorePause")
        {
            multiplier = 0;
            Invoke("ReturnMultiplier", 2);
            Destroy(other.gameObject);
        }
    }
}
