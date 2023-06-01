using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Properties")]
    public string gameScreenName;

    public void StartGame()
    {
        SceneManager.LoadScene(gameScreenName);
    }
}
