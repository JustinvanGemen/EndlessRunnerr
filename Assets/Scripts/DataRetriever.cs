using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataRetriever : MonoBehaviour {
    [SerializeField]
    private Text info;
    private string[] naam;
	// Use this for initialization
	IEnumerator Start () {
        WWW dataInformation = new WWW("http://jvdwijk.com/PHP/index.php");
        yield return dataInformation;
        string textData = dataInformation.text;
        Debug.Log(textData);
        textData.Split(";"[0]);
        info.text = textData;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
