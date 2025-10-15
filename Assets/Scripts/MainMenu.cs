using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;

    public void OpenMainMenuPanel()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenOptions()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("TowerLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
