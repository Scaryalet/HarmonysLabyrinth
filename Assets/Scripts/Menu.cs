using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Calls the Scene Manager to load scene 1
    public void onNewGameButton ()
    {
        SceneManager.LoadScene(2);
    }

    // Closes the application when exit button is clicked
    public void onExitButton()
    {
        Application.Quit();
    }

}
