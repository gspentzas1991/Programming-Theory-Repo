using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //ABSTRACTION - classes call the public StartGame function, which uses low-level private methods to complete the task
    public void StartGame()
    {
        LoadScene(1);
    }

    public void ReturnToMainMenu()
    {
        LoadScene(0);
    }

    private void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

}
