using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private GameObject _restartButton;

    public void RestartScene()
    {
        SceneManager.LoadScene("Game");
        _restartButton.SetActive(false);
        Time.timeScale = 1;
    }
}
