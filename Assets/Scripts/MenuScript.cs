using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField]
    private Canvas[] menus; //always put in the main menu first!

    void Awake()
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i] = menus[i].GetComponent<Canvas>();
            if(menus[i] != menus[0]) 
            {
                menus[i].enabled = false;
            }
            else
            {
                menus[i].enabled = true;
            }
        }
    }

    public void ScreenUpdate(Canvas menu)
    {
        Debug.Log(menu.name);
        for (int i = 0; i < menus.Length; i++)
        {
            Debug.Log(menus[i].name);
            if (menus[i].name == menu.name)
            {
                menus[i].enabled = true;
            }
            else
            {
                menus[i].enabled = false;
            }
        }       
    }
}
