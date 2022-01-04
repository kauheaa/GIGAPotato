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
    [SerializeField] private Transform addLevel1Canvas;
    [SerializeField] private Transform addLevel1Start;
    [SerializeField] private Transform addLevel1Level;
    [SerializeField] private Transform addLevel1End;
    [SerializeField] private Transform addLevel2Canvas;
    [SerializeField] private Transform addLevel2Start;
    [SerializeField] private Transform addLevel2Level;
    [SerializeField] private Transform addLevel2End;
    [SerializeField] private Transform addLevel3Canvas;
    [SerializeField] private Transform addLevel3Start;
    [SerializeField] private Transform addLevel3Level;
    [SerializeField] private Transform addLevel3End;
    [SerializeField] private Transform subLevel1Canvas;
    [SerializeField] private Transform subLevel1Start;
    [SerializeField] private Transform subLevel1Level;
    [SerializeField] private Transform subLevel1End;
    [SerializeField] private Transform subLevel2Canvas;
    [SerializeField] private Transform subLevel2Start;
    [SerializeField] private Transform subLevel2Level;
    [SerializeField] private Transform subLevel2End;
    [SerializeField] private Transform subLevel3Canvas;
    [SerializeField] private Transform subLevel3Start;
    [SerializeField] private Transform subLevel3Level;
    [SerializeField] private Transform subLevel3End;
    [SerializeField] private Transform countLevel1Canvas;
    [SerializeField] private Transform countLevel1Start;
    [SerializeField] private Transform countLevel1Level;
    [SerializeField] private Transform countLevel1End;
    [SerializeField] private Transform countLevel2Canvas;
    [SerializeField] private Transform countLevel2Start;
    [SerializeField] private Transform countLevel2Level;
    [SerializeField] private Transform countLevel2End;
    [SerializeField] private Transform countLevel3Canvas;
    [SerializeField] private Transform countLevel3Start;
    [SerializeField] private Transform countLevel3Level;
    [SerializeField] private Transform countLevel3End; 
    [SerializeField] private Transform levelExitWarning;



    private void Start()
    {
       
    }

    private void Update()
    {
        PauseGame();
    }

    public void MoveToJungle()
    {
        SceneManager.LoadScene("Jungle");
    }

    public void MoveToFarm()
    {
        SceneManager.LoadScene("Main");
    }

    public void MoveToSpace()
    {
        SceneManager.LoadScene("Space");
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
    public void OpenAddLevel1Canvas()
    {
        addLevel1Canvas.gameObject.SetActive(true);
    }
    public void CloseAddLevel1Canvas()
    {
        addLevel1Canvas.gameObject.SetActive(false);
    }
    public void OpenAddLevel1Start()
    {
        addLevel1Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel1Start()
    {
        addLevel1Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel1Level()
    {
        addLevel1Level.gameObject.SetActive(true);
    }
    public void CloseAddLevel1Level()
    {
        addLevel1Level.gameObject.SetActive(false);
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
    public void OpenAddLevel2Canvas()
    {
        addLevel2Canvas.gameObject.SetActive(true);
    }
    public void CloseAddLevel2Canvas()
    {
        addLevel2Canvas.gameObject.SetActive(false);
    }
    public void OpenAddLevel2Start()
    {
        addLevel2Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel2Start()
    {
        addLevel2Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel2Level()
    {
        addLevel2Level.gameObject.SetActive(true);
    }
    public void CloseAddLevel2Level()
    {
        addLevel2Level.gameObject.SetActive(false);
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
    public void OpenAddLevel3Canvas()
    {
        addLevel3Canvas.gameObject.SetActive(true);
    }
    public void CloseAddLevel3Canvas()
    {
        addLevel3Canvas.gameObject.SetActive(false);
    }
    public void OpenAddLevel3Start()
    {
        addLevel3Start.gameObject.SetActive(true);
    }
    public void CloseAddLevel3Start()
    {
        addLevel3Start.gameObject.SetActive(false);
    }
    public void OpenAddLevel3Level()
    {
        addLevel3Level.gameObject.SetActive(true);
    }
    public void CloseAddLevel3Level()
    {
        addLevel3Level.gameObject.SetActive(false);
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
    public void OpenSubLevel1Canvas()
    {
        subLevel1Canvas.gameObject.SetActive(true);
    }
    public void CloseSubLevel1Canvas()
    {
        subLevel1Canvas.gameObject.SetActive(false);
    }
    public void OpenSubLevel1Start()
    {
        subLevel1Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel1Start()
    {
        subLevel1Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel1Level()
    {
        subLevel1Level.gameObject.SetActive(true);
    }
    public void CloseSubLevel1Level()
    {
        subLevel1Level.gameObject.SetActive(false);
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
    public void OpenSubLevel2Canvas()
    {
        subLevel2Canvas.gameObject.SetActive(true);
    }
    public void CloseSubLevel2Canvas()
    {
        subLevel2Canvas.gameObject.SetActive(false);
    }
    public void OpenSubLevel2Start()
    {
        subLevel2Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel2Start()
    {
        subLevel2Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel2Level()
    {
        subLevel2Level.gameObject.SetActive(true);
    }
    public void CloseSubLevel2Level()
    {
        subLevel2Level.gameObject.SetActive(false);
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
    public void OpenSubLevel3Canvas()
    {
        subLevel3Canvas.gameObject.SetActive(true);
    }
    public void CloseSubLevel3Canvas()
    {
        subLevel3Canvas.gameObject.SetActive(false);
    }
    public void OpenSubLevel3Start()
    {
        subLevel3Start.gameObject.SetActive(true);
    }
    public void CloseSubLevel3Start()
    {
        subLevel3Start.gameObject.SetActive(false);
    }
    public void OpenSubLevel3Level()
    {
        subLevel3Level.gameObject.SetActive(true);
    }
    public void CloseSubLevel3Level()
    {
        subLevel3Level.gameObject.SetActive(false);
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
    public void OpenCountLevel1Canvas()
    {
        countLevel1Canvas.gameObject.SetActive(true);
    }
    public void CloseCountLevel1Canvas()
    {
        countLevel1Canvas.gameObject.SetActive(false);
    }
    public void OpenCountLevel1Start()
    {
        countLevel1Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel1Start()
    {
        countLevel1Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel1Level()
    {
        countLevel1Level.gameObject.SetActive(true);
    }
    public void CloseCountLevel1Level()
    {
        countLevel1Level.gameObject.SetActive(false);
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
    
    public void OpenCountLevel2Canvas()
    {
        countLevel2Canvas.gameObject.SetActive(true);
    }
    public void CloseCountLevel2Canvas()
    {
        countLevel2Canvas.gameObject.SetActive(false);
    }
    public void OpenCountLevel2Start()
    {
        countLevel2Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel2Start()
    {
        countLevel2Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel2Level()
    {
        countLevel2Level.gameObject.SetActive(true);
    }
    public void CloseCountLevel2Level()
    {
        countLevel2Level.gameObject.SetActive(false);
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
    
    public void OpenCountLevel3Canvas()
    {
        countLevel3Canvas.gameObject.SetActive(true);
    }
    public void CloseCountLevel3Canvas()
    {
        countLevel3Canvas.gameObject.SetActive(false);
    }
    public void OpenCountLevel3Start()
    {
        countLevel3Start.gameObject.SetActive(true);
    }
    public void CloseCountLevel3Start()
    {
        countLevel3Start.gameObject.SetActive(false);
    }
    public void OpenCountLevel3Level()
    {
        countLevel3Level.gameObject.SetActive(true);
    }
    public void CloseCountLevel3Level()
    {
        countLevel3Level.gameObject.SetActive(false);
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
