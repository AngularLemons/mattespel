using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public List<Question> Q;
    public GameObject[] options;
    public int currentQuestion;
    

    [SerializeField]
    public Image please;

    private void Start()
    {
        generateQuestion();
    }

    public void Correct()
    {
        Q.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void Wrong()
    {
        Q.RemoveAt(currentQuestion);
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<NewAnswer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = Q[currentQuestion].Answers[i];

            if (Q[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<NewAnswer>().isCorrect = true;
            }
        }

    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, Q.Count);
        please.sprite = Q[currentQuestion].fraga;
        SetAnswer();


    }

}
