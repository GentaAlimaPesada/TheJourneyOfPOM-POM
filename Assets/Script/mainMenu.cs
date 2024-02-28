using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene("IN GAME(SUMMER)"); 
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MAIN MENU");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
