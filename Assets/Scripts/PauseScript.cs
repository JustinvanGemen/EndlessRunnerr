using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

    private MenuScript menuScript;


    void Start()
    {
        menuScript = GetComponent<MenuScript>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            Paused();
        } 
	}

    public void Paused()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Canvas uiCanvas = menuScript.getCanvas(0);
            menuScript.ScreenUpdate(uiCanvas);
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

            Canvas pauseCanvas = menuScript.getCanvas(1);
            Debug.Log(pauseCanvas);
            menuScript.ScreenUpdate(pauseCanvas);
        }
    }
}
