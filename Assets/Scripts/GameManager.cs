using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string UserName { get; private set; }

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // Ensure only one instance of GameManager exists (Singleton pattern)
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }
    // Singleton instance
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame(string userName)
    {
        Debug.Log($"Game started for user: {userName}");
        // Add additional game start logic here
        UserName = userName;
    }
}
