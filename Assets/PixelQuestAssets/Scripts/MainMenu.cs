using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string startLevel = "TestLevel"; // Level we are going to start the game from
    public string menuScene = "Main Menu";


    // Used by the UI button to load us into the given level 
    public void StartButton()
    {
        SceneManager.LoadScene(startLevel);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(menuScene);
    }


}
