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
    [SerializeField] private Transform level1;
    [SerializeField] private Transform level2;
    [SerializeField] private Transform level3;
    [SerializeField] private Transform level4;
    [SerializeField] private Transform level5;
    [SerializeField] private Transform level6;
    [SerializeField] private Transform level7;
    [SerializeField] private Transform level8;
    [SerializeField] private Transform level9;
    [SerializeField] private Transform level10;
    [SerializeField] private Transform level11;





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
    public void OpenLevel1()
    {
        level1.gameObject.SetActive(true);
    }
    public void CloseLevel1()
    {
        level1.gameObject.SetActive(false);
    }
    public void OpenLevel2()
    {
        level2.gameObject.SetActive(true);
    }
    public void CloseLevel2()
    {
        level2.gameObject.SetActive(false);
    }
    public void OpenLevel3()
    {
        level3.gameObject.SetActive(true);
    }
    public void CloseLevel3()
    {
        level3.gameObject.SetActive(false);
    }
    public void OpenLevel4()
    {
        level4.gameObject.SetActive(true);
    }
    public void CloseLevel4()
    {
        level4.gameObject.SetActive(false);
    }
    public void OpenLevel5()
    {
        level5.gameObject.SetActive(true);
    }
    public void CloseLevel5()
    {
        level5.gameObject.SetActive(false);
    }
    public void OpenLevel6()
    {
        level6.gameObject.SetActive(true);
    }
    public void CloseLevel6()
    {
        level6.gameObject.SetActive(false);
    }
    public void OpenLevel7()
    {
        level7.gameObject.SetActive(true);
    }
    public void CloseLevel7()
    {
        level7.gameObject.SetActive(false);
    }
    public void OpenLevel8()
    {
        level8.gameObject.SetActive(true);
    }
    public void CloseLevel8()
    {
        level8.gameObject.SetActive(false);
    }
    public void OpenLevel9()
    {
        level9.gameObject.SetActive(true);
    }
    public void CloseLevel9()
    {
        level9.gameObject.SetActive(false);
    }
    public void OpenLevel10()
    {
        level10.gameObject.SetActive(true);
    }
    public void CloseLevel10()
    {
        level10.gameObject.SetActive(false);
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
