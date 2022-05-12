using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score;
    
    

    void Start()
    {
        
        score = 0;
    }

    public void AddScore(int add)
    {
        score += add;
       if(score == 16)
        {
            SceneManager.LoadScene("endmemory");
            Debug.Log("Snäll");
        }
    }
}
