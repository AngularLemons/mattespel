using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class token : MonoBehaviour
{
    SpriteRenderer sp;

    public Sprite face;
    public Sprite back;

    public void OnMouseDown()
    {
        if (sp.sprite == back)
        {
            sp.sprite = face;
        }
        else
        {
            sp.sprite = back;
        }

    }





    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }
}


