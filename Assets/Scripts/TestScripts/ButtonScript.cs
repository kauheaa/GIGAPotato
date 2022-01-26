using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        CalculateS varTemp = GameObject.Find("CalculateS").GetComponent<CalculateS>();
        varTemp.AddFunction();
    }
}
