using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAnswer : MonoBehaviour
{
    public bool isCorrect = false;
    public Manager manager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            manager.Correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            manager.Correct();
        }
    }
}
