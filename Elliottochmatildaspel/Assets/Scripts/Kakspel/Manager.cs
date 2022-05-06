using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public List<Question> Q;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject quizpanel;
    public GameObject overpanel;

    public Text scoretext;
    int totalquestions = 0;
    public int score;


    [SerializeField]
    public Image please;

    private void Start()
    {
        totalquestions = Q.Count;
        overpanel.SetActive(false);
        generateQuestion();
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void home()
    {
        SceneManager.LoadScene("Start");
    }

    void GameOver()
    {
        quizpanel.SetActive(false);
        overpanel.SetActive(true);
        scoretext.text = score + "/" + totalquestions;
    }

    public void Correct()
    {
        score += 1;
        Q.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void Wrong()
    {
        Q.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<NewAnswer>().colour;
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
        if (Q.Count > 0)
        {
            currentQuestion = Random.Range(0, Q.Count);
            please.sprite = Q[currentQuestion].fraga;
            SetAnswer();
        }
        else
        {
            Debug.Log("out of questions");
            GameOver();
        }


    }

}
