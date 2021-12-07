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
    [SerializeField] private Transform countingCat;
    [SerializeField] private Transform addLevel1;
    [SerializeField] private Transform addLevel2;
    [SerializeField] private Transform addLevel3;
    [SerializeField] private Transform subLevel1;
    [SerializeField] private Transform subLevel2;
    [SerializeField] private Transform subLevel3;
    [SerializeField] private Transform countLevel1;
    [SerializeField] private Transform countLevel2;
    [SerializeField] private Transform countLevel3;
    [SerializeField] private Transform level11;





    private void Start()
    {
       
    }

    private void Update()
    {
        PauseGame();
    }

    public void OpenStickerBook()
    {
        stickerBook.gameObject.SetActive(true);
    }
    public void CloseStickerBook()
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
        countingCat.gameObject.SetActive(true);
    }
    public void CloseCountingCategory()
    {
        countingCat.gameObject.SetActive(false);
    }
    public void OpenAddLevel1()
    {
        addLevel1.gameObject.SetActive(true);
    }
    public void CloseAddLevel1()
    {
        addLevel1.gameObject.SetActive(false);
    }
    public void OpenAddLevel2()
    {
        addLevel2.gameObject.SetActive(true);
    }
    public void CloseAddLevel2()
    {
        addLevel2.gameObject.SetActive(false);
    }
    public void OpenAddLevel3()
    {
        addLevel3.gameObject.SetActive(true);
    }
    public void CloseAddLevel3()
    {
        addLevel3.gameObject.SetActive(false);
    }
    public void OpenSubLevel1()
    {
        subLevel1.gameObject.SetActive(true);
    }
    public void CloseSubLevel1()
    {
        subLevel1.gameObject.SetActive(false);
    }
    public void OpenSubLevel2()
    {
        subLevel2.gameObject.SetActive(true);
    }
    public void CloseSubLevel2()
    {
        subLevel2.gameObject.SetActive(false);
    }
    public void OpenSubLevel3()
    {
        subLevel3.gameObject.SetActive(true);
    }
    public void CloseSubLevel3()
    {
        subLevel3.gameObject.SetActive(false);
    }
    public void OpenCountLevel1()
    {
        countLevel1.gameObject.SetActive(true);
    }
    public void CloseCountLevel1()
    {
        countLevel1.gameObject.SetActive(false);
    }
    public void OpenCountLevel2()
    {
        countLevel2.gameObject.SetActive(true);
    }
    public void CloseCountLevel2()
    {
        countLevel2.gameObject.SetActive(false);
    }
    public void OpenCountLevel3()
    {
        countLevel3.gameObject.SetActive(true);
    }
    public void CloseCountLevel3()
    {
        countLevel3.gameObject.SetActive(false);
    }
    public void OpenLevel11()
    {
        level11.gameObject.SetActive(true);
    }
    public void CloseLevel11()
    {
        level11.gameObject.SetActive(false);
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
