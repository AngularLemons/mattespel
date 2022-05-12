using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PuzzlePiece : MonoBehaviour
{
    // [SerializeField] private AudioSource _source;
    //[SerializeField] private AudioClip _pickUpClip, _dropClip;
    [SerializeField] private SpriteRenderer _renderer;


    private bool _dragging, _placed;
    private Vector2 _offset, _originalPosition;
    //Sprite face;
    Vector3 offset;

    public GameManager gm;
    

    private int score;
    public GameObject gameobject;


   
    private PuzzleSlot _slot;

    private void Start()
    {
        score = 0;
    }
    public void Init(PuzzleSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;
        _slot = slot;
    }

   /* private void Awake()
    {
        _originalPosition = transform.position;
       
    }*/
    
   /* private void Update()
    {
        if (_placed) return;
           
        //if (!_dragging) return;

       // var mousePosition = GetMousePos();

       // transform.position = mousePosition - _offset;
     
    }*/
   
    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        /*_dragging = true;
        //_source.PlayOneShot(_pickUpClip);

        _offset = GetMousePos() - (Vector2)transform.position;*/
    }

  

  

    /*void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, _slot.transform.position) < 3)
        {
            transform.position = _slot.transform.position;


            _placed = true;

            if (_placed == true)
            {
                score += 1;
            }*

            
            
        }
        else
        {
            transform.position = _originalPosition;
            _dragging = false;
        }

        if(score == 4)
        {
            SceneManager.LoadScene("endmemory");
        }
       

    }*/

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;

        if (Vector2.Distance(transform.position, _slot.transform.position) < 2)
        {
            transform.position = _slot.transform.position;

            //_placed = true;

            AddScore();
            
            


            

                
                /*if (score == 1000)
                {
                    SceneManager.LoadScene("endmemory");
                    Debug.Log("idiot");
                }*/


        }
        
      
    }



    /* Vector2 GetMousePos()
     {
         return Camera.main.ScreenToWorldPoint(Input.mousePosition);
     }*/

    public void AddScore()
    {
        score += 1;

        if (score == 3)
        {
            
        Debug.Log("piss");
            SceneManager.LoadScene("endmemory");
            Debug.Log("fuck");
        }
       

        

    }

    


}
