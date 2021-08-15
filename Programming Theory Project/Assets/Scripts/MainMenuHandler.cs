using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    public TMP_InputField usernameInput;

    public void StartGame()
    {
        if (usernameInput != null)
        {
            DataManager.username = usernameInput.text;
        }
        GameManager.Instance.StartGame();
    }
}
