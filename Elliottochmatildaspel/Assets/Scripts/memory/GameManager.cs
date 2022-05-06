using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

   void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += 1;
        if(score == 4)
        {
            SceneManager.LoadScene("endmemory");
        }
    }


}
