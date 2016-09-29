using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //import sceneManagement to go to different scenes.
//Joey vd Wijk
public class SceneChanger : MonoBehaviour {

    public void ChangeScene(int scene) //change the scene, The int decides what scenes you change to. ex: 0 = Main Menu.
    {
        SceneManager.LoadScene(scene);
    }
}
