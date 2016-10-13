using UnityEngine;
using System.Collections;

public class DataBase : MonoBehaviour
{
    private UIUpdater uiUpdater;
    private float score;
    // Use this for initialization
    public void SendScore()
    {
        uiUpdater = GetComponent<UIUpdater>();
        score = uiUpdater.ScorePoints;
        score = Mathf.Round(score);
        //ERG BELANGRIJK
        StartCoroutine(HandleEnterScore(score, 1));
    }

    public IEnumerator HandleEnterScore(float score, int playerID)
    {
        Debug.Log("Start Couroutine");

        //Create the url of the script with the variables that will be written to the database.
        //Om dit te debuggen kan je deze url invullen in je browser
        string score_url = "http://jvdwijk.com/PHP/database.php" + "?score=" + score;

        //Go to the url and get whatever the url is printing out
        WWW webRequest = new WWW(score_url);

        //wait until the site is done loading before continueing.
        //Zet deze Yield return maar aan het einde van deze functie en zie wat er gebeurt. 
        yield return webRequest;

        //Display the output. 
        //Waarom is dit geen goede error handeling?
        if (webRequest.text != "")
        {
            Debug.Log("PHP Success: " + webRequest.text);
        }
        else
        {
            Debug.Log("PHP Fail ");
        }

    }
}
