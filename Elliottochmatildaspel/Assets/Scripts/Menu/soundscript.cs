using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundscript : MonoBehaviour
{
    private Sprite onImage;
    public Sprite offImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        onImage = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void klick()
    {
        if (isOn)
        {
            button.image.sprite = offImage;
            isOn = false;
            audio.mute = true;
        }
        else
        {
            button.image.sprite = onImage;
            isOn = true;
            audio.mute = false;
        }
    }
}
