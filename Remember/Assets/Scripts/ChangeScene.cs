using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public enum Type { Start, Control, Exit, Main }
    public Type type;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        switch (type)
        {
            case Type.Start:
                StartGame();
                break;
            case Type.Control:
                Controls();
                break;
            case Type.Exit:
                EndGame();
                break;
            case Type.Main:
                MainScreen();
                break;
        }
    }

    public void StartGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("World");
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void MainScreen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

