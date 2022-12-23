using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Persist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<Scene_Persist>().Length;

        if (numScenePersists > 1) 
        {
            Destroy(gameObject);
        }
        else {
                DontDestroyOnLoad(gameObject);
            }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
