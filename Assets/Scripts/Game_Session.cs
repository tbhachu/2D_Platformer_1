using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Session : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    
    void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        
        if (numGameSessions > 1) {
            Destroy(gameObject);
        }
        else {
                DontDestroyOnLoad(gameObject);
            }
        }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1){
            TakeLife();
        } else {
            ResetGameSession();
        }
    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
    }
}
