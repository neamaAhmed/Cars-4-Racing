using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject scoreText;
    public GameObject restartText;
    public GameObject gameOverText;
    private bool gameOver;
    private bool restart;
    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.GetComponent<Text>().text = "";
        gameOverText.GetComponent<Text>().text = "";
        //StartCoroutine (SpawnWaves );
        //GameOver();
    }

    void Update ()
    {

        if (restart)
        {
            restartText.GetComponent<Text>().text = "Press R to restart ";
            if (Input.GetKeyDown (KeyCode.R))
            {
                this.Start();
                // Type or member is obsolete

                #pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel (Application.loadedLevel);
                #pragma warning restore CS0618 // Type or member is obsolete
                              // Type or member is obsolete
            }
        }
    }
    /*
    IEnumerator SpawnWaves
    {
        get
        {
            while (true)
            {

                if (gameOver)
                {
                    restartText.text = "Press 'R' for Restart";
                    restart = true;
                    break;
                    return;
                }
            }
        }
    }
    */
    public void GameOver ()
    {
        gameOverText.GetComponent<Text>().text = "Game Over!";
        gameOver = true;
        restart = true;
    }
}