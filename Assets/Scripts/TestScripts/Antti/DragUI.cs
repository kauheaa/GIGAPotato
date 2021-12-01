using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragUI : EventTrigger
{

    private bool startDragging;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
       startDragging = true;
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("AnswerSpot"))
        {

            Debug.Log("Correct");

        }
    }


        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AnswerSpot"))
        {
           
        }
       
    }
}
