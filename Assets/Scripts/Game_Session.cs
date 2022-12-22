using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Session : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    
    void Awake()
    {
        int numGameSessions = FindObjectsOfType<Game_Session>().Length;

        if (numGameSessions > 1) {
            Destroy(gameObject);
        }
        else {
                DontDestroyOnLoad(gameObject);
            }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        } 
        else 
        {
            ResetGameSession();
        }
    }

    void TakeLife()
    {
        playerLives--;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void ResetGameSession()
    {
        Debug.Log("Game session has restarted.");
        SceneManager.LoadScene(0);
    }
}
