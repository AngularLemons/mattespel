using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NewAnswer : MonoBehaviour
{
    public bool isCorrect = false;
    public Manager Manager;
    

    public Color colour;

    private void Start()
    {
         colour =  GetComponent<Image>().color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            Manager.Correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            Manager.Wrong();
        }
    }
}
