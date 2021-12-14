using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{    
    [SerializeField] private Transform settingsMenu;
    [SerializeField] private Transform stickerBook;
    [SerializeField] private Transform stickerSpreadFirst;
    [SerializeField] private Transform stickerSpreadMid1;
    [SerializeField] private Transform stickerSpreadLast;
    [SerializeField] private Transform farmWorld;
    [SerializeField] private Transform additionCat;
    [SerializeField] private Transform substractCat;
    [SerializeField] private Transform countingCat;
    [SerializeField] private Transform addLevel1Start;
    [SerializeField] private Transform addLevel1;
    [SerializeField] private Transform addLevel1End;
    [SerializeField] private Transform addLevel2Start;
    [SerializeField] private Transform addLevel2;
    [SerializeField] private Transform addLevel2End;
    [SerializeField] private Transform addLevel3Start;
    [SerializeField] private Transform addLevel3;
    [SerializeField] private Transform addLevel3End;
    [SerializeField] private Transform subLevel1Start;
    [SerializeField] private Transform subLevel1;
    [SerializeField] private Transform subLevel1End;
    [SerializeField] private Transform subLevel2Start;
    [SerializeField] private Transform subLevel2;
    [SerializeField] private Transform subLevel2End;
    [SerializeField] private Transform subLevel3Start;
    [SerializeField] private Transform subLevel3;
    [SerializeField] private Transform subLevel3End;
    [SerializeField] private Transform countLevel1Start;
    [SerializeField] private Transform countLevel1;
    [SerializeField] private Transform countLevel1End;
    [SerializeField] private Transform countLevel2Start;
    [SerializeField] private Transform countLevel2;
    [SerializeField] private Transform countLevel2End;
    [SerializeField] private Transform countLevel3Start;
    [SerializeField] private Transform countLevel3;
    [SerializeField] private Transform countLevel3End;
    [SerializeField] private Transform levelExitWarning;





    private void Start()
    {
       
    }

    private void Update()
    {
        PauseGame();
    }

    /*Stickerbook related buttons*/
    public void OpenStickerBook()
    {
        stickerBook.gameObject.SetActive(true);
    }
    public void CloseStickerBook()
    {
        stickerBook.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadFirst()
    {
        stickerSpreadFirst.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadFirst()
    {
        stickerSpreadFirst.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadMid1()
    {
        stickerSpreadMid1.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadMid1 ()
    {
        stickerSpreadMid1.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadLast()
    {
        stickerSpreadLast.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadLast()
    {
        stickerSpreadLast.gameObject.SetActive(false);
    }


    public void OpenFarmWorld()
    {
        farmWorld.gameObject.SetActive(true);
    }
    public void CloseFarmWorld()
    {
        farmWorld.gameObject.SetActive(false);
    }

    /*Farm Category menu buttons*/
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

    /*Farm Addition level 1 buttons*/
    public void OpenAddLevel1Start()
    {
        addLevel1Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel1Start()
    {
        addLevel1Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel1()
    {
        addLevel1.gameObject.SetActive(true);
    }
    public void CloseAddLevel1()
    {
        addLevel1.gameObject.SetActive(false);
    }
    public void OpenAddLevel1End()
    {
        addLevel1End.gameObject.SetActive(true);
    }
    public void CloseAddLevel1End()
    {
        addLevel1End.gameObject.SetActive(false);
    }

    /*Farm Addition level 2 buttons*/
    public void OpenAddLevel2Start()
    {
        addLevel2Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel2Start()
    {
        addLevel2Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel2()
    {
        addLevel2.gameObject.SetActive(true);
    }
    public void CloseAddLevel2()
    {
        addLevel2.gameObject.SetActive(false);
    }
    public void OpenAddLevel2End()
    {
        addLevel2End.gameObject.SetActive(true);
    }
    public void CloseAddLevel2End()
    {
        addLevel2End.gameObject.SetActive(false);
    }

    /*Farm Addition level 3 buttons*/
    public void OpenAddLevel3Start()
    {
        addLevel3Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel3Start()
    {
        addLevel3Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel3()
    {
        addLevel3.gameObject.SetActive(true);
    }
    public void CloseAddLevel3()
    {
        addLevel3.gameObject.SetActive(false);
    }
    public void OpenAddLevel3End()
    {
        addLevel3End.gameObject.SetActive(true);
    }
    public void CloseAddLevel3End()
    {
        addLevel3End.gameObject.SetActive(false);
    }

    /*Farm Subtraction level 1 buttons*/
    public void OpenSubLevel1Start()
    {
        subLevel1Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel1Start()
    {
        subLevel1Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel1()
    {
        subLevel1.gameObject.SetActive(true);
    }
    public void CloseSubLevel1()
    {
        subLevel1.gameObject.SetActive(false);
    }
    public void OpenSubLevel1End()
    {
        subLevel1End.gameObject.SetActive(true);
    }
    public void CloseSubLevel1End()
    {
        subLevel1End.gameObject.SetActive(false);
    }

    /*Farm Subtraction level 2 buttons*/
    public void OpenSubLevel2Start()
    {
        subLevel2Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel2Start()
    {
        subLevel2Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel2()
    {
        subLevel2.gameObject.SetActive(true);
    }
    public void CloseSubLevel2()
    {
        subLevel2.gameObject.SetActive(false);
    }
    public void OpenSubLevel2End()
    {
        subLevel2End.gameObject.SetActive(true);
    }
    public void CloseSubLevel2End()
    {
        subLevel2End.gameObject.SetActive(false);
    }

    /*Farm Subtraction level 3 buttons*/
    public void OpenSubLevel3Start()
    {
        subLevel3Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel3Start()
    {
        subLevel3Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel3()
    {
        subLevel3.gameObject.SetActive(true);
    }
    public void CloseSubLevel3()
    {
        subLevel3.gameObject.SetActive(false);
    }
    public void OpenSubLevel3End()
    {
        subLevel3End.gameObject.SetActive(true);
    }
    public void CloseSubLevel3End()
    {
        subLevel3End.gameObject.SetActive(false);
    }

    /*Farm Counting level 1 buttons*/
    public void OpenCountLevel1Start()
    {
        countLevel1Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel1Start()
    {
        countLevel1Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel1()
    {
        countLevel1.gameObject.SetActive(true);
    }
    public void CloseCountLevel1()
    {
        countLevel1.gameObject.SetActive(false);
    }
    public void OpenCountLevel1End()
    {
        countLevel1End.gameObject.SetActive(true);
    }
    public void CloseCountLevel1End()
    {
        countLevel1End.gameObject.SetActive(false);
    }

    /*Farm Counting level 2 buttons*/
    public void OpenCountLevel2Start()
    {
        countLevel2Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel2Start()
    {
        countLevel2Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel2()
    {
        countLevel2.gameObject.SetActive(true);
    }
    public void CloseCountLevel2()
    {
        countLevel2.gameObject.SetActive(false);
    }
    public void OpenCountLevel2End()
    {
        countLevel2End.gameObject.SetActive(true);
    }
    public void CloseCountLevel2End()
    {
        countLevel2End.gameObject.SetActive(false);
    }

    /*Farm Counting level 3 buttons*/
    public void OpenCountLevel3Start()
    {
        countLevel3Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel3Start()
    {
        countLevel3Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel3()
    {
        countLevel3.gameObject.SetActive(true);
    }
    public void CloseCountLevel3()
    {
        countLevel3.gameObject.SetActive(false);
    }
    public void OpenCountLevel3End()
    {
        countLevel3End.gameObject.SetActive(true);
    }
    public void CloseCountLevel3End()
    {
        countLevel3End.gameObject.SetActive(false);
    }

    /*Exit level warning popup*/
    public void OpenLevelExitWarning()
    {
        levelExitWarning.gameObject.SetActive(true);
    }
    public void CloseLevelExitWarning()
    {
        levelExitWarning.gameObject.SetActive(false);
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
