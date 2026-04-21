using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("CharacterDressUp");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Iziet no spēles");
    }
}