using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCount : MonoBehaviour
{
    private CalculateS calculate;
    public GameObject star1, star2, star3, star4, star5, star6;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (calculate.score >= 5)
        {

            star1.gameObject.SetActive(true);
        }

        if (calculate.score >= 10)
        {
            star2.gameObject.SetActive(true);
        }

        if (calculate.score >= 15)
        {
            star3.gameObject.SetActive(true);
        }

        /*if(calculate.jungleScore >= 5)
        {
            sticker4.gameObject.SetActive(true);
        }*/

    }
}