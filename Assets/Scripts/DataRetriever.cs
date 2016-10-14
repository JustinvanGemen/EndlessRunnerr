using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataRetriever : MonoBehaviour {
    [SerializeField]
    private Text info;
    private string[] scores;
	// Use this for initialization
	IEnumerator Start () {
        WWW dataInformation = new WWW("http://jvdwijk.com/PHP/index.php");
        yield return dataInformation;
        string textData = dataInformation.text;
        Debug.Log(textData);
        scores = textData.Split(";"[0]);
        info.text = scores[0] + "\n" + scores[1] + "\n" + scores [2] + "\n" + scores[3] + "\n" + scores[4];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
