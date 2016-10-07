using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//Joey vd Wijk
public class HealthSystem : MonoBehaviour {
    public float lifes = 3; //make a float for the players life, give him 3. (if you want you can change it in the editor)
    [SerializeField]
    private Canvas gameOverCanvas;
    [SerializeField]
    private Text text;
    private MenuScript menuScript;  //import menuscript as var.
    private bool godMode = false;

    void Start()
    {
        gameOverCanvas.enabled = false;
        menuScript = GetComponent<MenuScript>();  //instantiate menuscript.
    }
	
    void OnTriggerEnter2D (Collider2D other) //if something that has trigger enabled, hits the player
    {
        if (other.CompareTag("Obstacle") && godMode == false) //if player hits an obstacle remove a life from the player.
        {
            lifes -= 1;
        }
        if (lifes <= 0) //if player runs out of lifes continue.
        {
            gameOverCanvas.enabled = true;
            if (gameObject.CompareTag("Player")) //if Player 1 died change text.
            {
                text.text = "Player 2 Won!";
            }
            else //if player 2 died change text.
            {
                text.text = "Player 1 Won!";
            }
            Destroy(gameObject); //Destroy the player with no lifes.
            Time.timeScale = 0; //pause the game.
        }
        if(other.name == "ExtraLife")
        {
            lifes += 1;
            Destroy(other.gameObject);
        }
        if(other.name == "GodMode")
        {
            godMode = true;
            Invoke("GodModeOff", 3);
        }
    }
    private void GodModeOff()
    {
        godMode = false;
    }
}
