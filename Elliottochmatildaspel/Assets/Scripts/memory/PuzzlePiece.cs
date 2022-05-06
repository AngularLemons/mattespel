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
    Sprite face;
    public GameManager gm;

    public int score = 0;


   
    private PuzzleSlot _slot;
    public void Init(PuzzleSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;
        _slot = slot;
    }

    private void Awake()
    {
        _originalPosition = transform.position;
       
    }
    private void Update()
    {
        if (_placed) return;
        if (!_dragging) return;


        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;
    }
    private void OnMouseDown()
    {
       
        _dragging = true;
        //_source.PlayOneShot(_pickUpClip);

        _offset = GetMousePos() - (Vector2)transform.position;
    }
    

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, _slot.transform.position) < 3)
        {
            transform.position = _slot.transform.position;
            
            _placed = true;
            score += 1;

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

    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    


}
