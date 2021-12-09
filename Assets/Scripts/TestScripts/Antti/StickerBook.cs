using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerBook : MonoBehaviour
{
    private CalculateS calculate;
    public GameObject sticker1, sticker2, sticker3, sticker4, sticker5, sticker6;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if(calculate.score >= 5)
        {

            sticker1.gameObject.SetActive(true);
        }

        if (calculate.score >= 10)
        {
            sticker2.gameObject.SetActive(true);
        }

        if (calculate.score >= 15)
        {
            sticker3.gameObject.SetActive(true);
        }

        /*if(calculate.jungleScore >= 5)
        {
            sticker4.gameObject.SetActive(true);
        }*/
        
    }
}
