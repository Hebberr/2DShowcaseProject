using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (GetComponent<Canvas>().enabled == true)
            {
                ResumeGame();
            }
            else if (GetComponent<Canvas>().enabled == false)
            {
                PauseGame();
            }
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            ReloadLevel();
        }
        if (Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            LoadMainMenu();
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        GetComponent<Canvas>().enabled = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
