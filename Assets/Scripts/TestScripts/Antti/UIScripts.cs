using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour
{
    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1;
        playerMov.currentState = PlayerState.walk;
    }

}
