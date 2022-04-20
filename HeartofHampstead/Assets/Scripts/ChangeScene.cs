using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public enum Type { Start, Control, Exit, Main, Final, Epilog }
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
        FinalDecision.final = 0;
        ChoiceCheck.Decisions.evil = 0;
        ChoiceCheck.Decisions.power = 0;
        ChoiceCheck.Decisions.royalty = 0;
        ObjectController.Stats.day = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void ChoiceScreen()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("ChoiceSelect");
    }
    public void FinalDecScreen()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("FinalDecision");
    }

    public void EpilogScreen()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Epilog");
    }

}

