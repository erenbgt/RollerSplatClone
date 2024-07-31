using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] grounds;

    public float groundNumbers;
    private int currentLevel;

    void Start()
    {
        grounds = GameObject.FindGameObjectsWithTag("Ground");
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        groundNumbers = grounds.Length;
    }

    public void LevelChange()
    {
        SceneManager.LoadScene(currentLevel + 1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
