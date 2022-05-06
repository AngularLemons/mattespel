using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Dialoguescript : MonoBehaviour
{

    public TextMeshProUGUI dia;
    public string[] lines;
    public float textspeed;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        dia.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(dia.text == lines[index])
            {
                Nextline();
            }
            else
            {
                StopAllCoroutines();
                dia.text = lines[index];

            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(kanske());
    }

    IEnumerator kanske()
    {
        foreach(char c in lines[index].ToCharArray()){
            dia.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void Nextline()
    {
        if(index < lines.Length - 1)
        {
            index++;
            dia.text = string.Empty;
            StartCoroutine(kanske());
        }
        else
        {
            SceneManager.LoadScene("kakspel");
        }
    }
}
