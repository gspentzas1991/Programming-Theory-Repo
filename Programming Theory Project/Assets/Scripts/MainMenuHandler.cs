using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_Text highscoreText;

    private void Start()
    {
        GameManager.Instance.UpdateHighscore(highscoreText);
    }

    public void StartGame()
    {
        if (usernameInput != null)
        {
            DataManager.username = usernameInput.text;
        }
        GameManager.Instance.StartGame();
    }
}
