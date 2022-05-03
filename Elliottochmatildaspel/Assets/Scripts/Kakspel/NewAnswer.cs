using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAnswer : MonoBehaviour
{
    public bool isCorrect = false;
    public Manager Manager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            Manager.Correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            Manager.Wrong();
        }
    }
}
