using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{    
    [SerializeField] private Transform settingsMenu;   
    [SerializeField] private Transform stickerBook;
    [SerializeField] private Transform farmWorld;
    [SerializeField] private Transform additionCat;
    [SerializeField] private Transform substractCat;
    [SerializeField] private Transform countCat;




    private void Start()
    {
       
    }

    private void Update()
    {
        PauseGame();
    }

    public void StickerButtonPressed()
    {
        stickerBook.gameObject.SetActive(true);
    }
    public void CloseSticker()
    {
        stickerBook.gameObject.SetActive(false);
    }
    public void OpenFarmWorld()
    {
        farmWorld.gameObject.SetActive(true);
    }
    public void CloseFarmWorld()
    {
        farmWorld.gameObject.SetActive(false);
    }
    public void OpenAdditionCategory()
    {
        additionCat.gameObject.SetActive(true);
    }
    public void CloseAdditionCategory()
    {
        additionCat.gameObject.SetActive(false);
    }
    public void OpenSubstractionCategory()
    {
        substractCat.gameObject.SetActive(true);
    }
    public void CloseSubstractionCategory()
    {
        substractCat.gameObject.SetActive(false);
    }
    public void OpenCountingCategory()
    {
        substractCat.gameObject.SetActive(true);
    }
    public void CloseCountingCategory()
    {
        substractCat.gameObject.SetActive(false);
    }


    public void SettingsButtonPressed()
    {
      
    }

    public void CancelButtonPressed()
    {
    }

    public void OKButtonPressed()
    {
        
    }   

    


    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
    }


    public void QuitButtonPressed()
    {
        
    }

  

    public void StartMenuCredits()
    {
        
    }
}
