using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScore : MonoBehaviour
{
    int score;

   void Start()
    {
        score = 0;
    }

    public void AddScore(int add)
    {
        score = score + add;
        if(score == 4)
        {
            SceneManager.LoadScene("endmemory");
        }
    }


}
