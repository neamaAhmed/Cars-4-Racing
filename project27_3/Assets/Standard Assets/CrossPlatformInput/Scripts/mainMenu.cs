using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

public void RacingMode()
    {
        SceneManager.LoadScene("final");
    }
    public void OpenAreaMode()
    {
        SceneManager.LoadScene("FreeGreenPlace");
    }
    public void Quite()
    {
        Debug.Log("Quite !");
        Application.Quit();
    }
}
