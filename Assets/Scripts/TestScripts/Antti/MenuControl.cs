using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public GameObject stickerbookButton;
    [SerializeField] private Transform settingsMenu;
    [SerializeField] private Transform stickerBook;
    [SerializeField] private Transform stickerSpreadFirst;
    [SerializeField] private Transform stickerSpreadMid1;
    [SerializeField] private Transform stickerSpreadMid2;
    [SerializeField] private Transform stickerSpreadMid3;
    [SerializeField] private Transform stickerSpreadMid4;
    [SerializeField] private Transform stickerSpreadLast;
    [SerializeField] private Transform farmWorld;
    [SerializeField] private Transform additionCat;
    [SerializeField] private Transform substractCat;
    [SerializeField] private Transform countingCat;
    [SerializeField] private Transform multiplyCat;
    [SerializeField] private Transform divideCat;
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
    [SerializeField] private Transform multLevel1Canvas;
    [SerializeField] private Transform multLevel1Start;
    [SerializeField] private Transform multLevel1Level;
    [SerializeField] private Transform multLevel1End;
    [SerializeField] private Transform multLevel2Canvas;
    [SerializeField] private Transform multLevel2Start;
    [SerializeField] private Transform multLevel2Level;
    [SerializeField] private Transform multLevel2End;
    [SerializeField] private Transform multLevel3Canvas;
    [SerializeField] private Transform multLevel3Start;
    [SerializeField] private Transform multLevel3Level;
    [SerializeField] private Transform multLevel3End;
    [SerializeField] private Transform divLevel1Canvas;
    [SerializeField] private Transform divLevel1Start;
    [SerializeField] private Transform divLevel1Level;
    [SerializeField] private Transform divLevel1End;
    [SerializeField] private Transform divLevel2Canvas;
    [SerializeField] private Transform divLevel2Start;
    [SerializeField] private Transform divLevel2Level;
    [SerializeField] private Transform divLevel2End;
    [SerializeField] private Transform divLevel3Canvas;
    [SerializeField] private Transform divLevel3Start;
    [SerializeField] private Transform divLevel3Level;
    [SerializeField] private Transform divLevel3End;
    [SerializeField] private Transform levelExitWarning;



    private void Start()
    {
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    private void Update()
    {
        PauseGame();
    }

    //public void ResetGame()
    //{
    //    StickerBook.setBool("AllScoresZero", true);
    //}

    public void MoveToJungle()
    {
        SceneManager.LoadScene("Jungle");
    }

    public void MoveToFarm()
    {
        SceneManager.LoadScene("Farm");
    }

    public void MoveToSpace()
    {
        SceneManager.LoadScene("Space");
    }

    public void MoveToMain()
    {
        SceneManager.LoadScene("Main");
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
    public void OpenStickerSpreadMid2()
    {
        stickerSpreadMid2.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadMid2()
    {
        stickerSpreadMid2.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadMid3()
    {
        stickerSpreadMid3.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadMid3()
    {
        stickerSpreadMid3.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadMid4()
    {
        stickerSpreadMid4.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadMid4()
    {
        stickerSpreadMid4.gameObject.SetActive(false);
    }
    public void OpenStickerSpreadLast()
    {
        stickerSpreadLast.gameObject.SetActive(true);
    }
    public void CloseStickerSpreadLast()
    {
        stickerSpreadLast.gameObject.SetActive(false);
    }


    public void PlaySaveAnim()
    {
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", true);
    }





    //FARM
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
    public void OpenMultiplyCategory()
    {
        multiplyCat.gameObject.SetActive(true);
    }
    public void CloseMultiplyCategory()
    {
        multiplyCat.gameObject.SetActive(false);
    }

    public void OpenDivideCategory()
    {
        divideCat.gameObject.SetActive(true);
    }
    public void CloseDivideCategory()
    {
        divideCat.gameObject.SetActive(false);
    }

    /*Addition level 1 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Addition level 2 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Addition level 3 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Subtraction level 1 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Subtraction level 2 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Subtraction level 3 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Counting level 1 buttons*/
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Counting level 2 buttons*/
    
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }
    
    /*Counting level 3 buttons*/
    
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
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Multiply level 1 buttons*/
    public void OpenMultLevel1Canvas()
    {
        multLevel1Canvas.gameObject.SetActive(true);
    }
    public void CloseMultLevel1Canvas()
    {
        multLevel1Canvas.gameObject.SetActive(false);
    }
    public void OpenMultLevel1Start()
    {
        multLevel1Start.gameObject.SetActive(true);
    }
    public void CloseMultLevel1Start()
    {
        multLevel1Start.gameObject.SetActive(false);
    }
    public void OpenMultLevel1Level()
    {
        multLevel1Level.gameObject.SetActive(true);
    }
    public void CloseMultLevel1Level()
    {
        multLevel1Level.gameObject.SetActive(false);
    }
    public void OpenMultLevel1End()
    {
        multLevel1End.gameObject.SetActive(true);
    }
    public void CloseMultLevel1End()
    {
        multLevel1End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Multiply level 2 buttons*/
    public void OpenMultLevel2Canvas()
    {
        multLevel2Canvas.gameObject.SetActive(true);
    }
    public void CloseMultLevel2Canvas()
    {
        multLevel2Canvas.gameObject.SetActive(false);
    }
    public void OpenMultLevel2Start()
    {
        multLevel2Start.gameObject.SetActive(true);
    }
    public void CloseMultLevel2Start()
    {
        multLevel2Start.gameObject.SetActive(false);
    }
    public void OpenMultLevel2Level()
    {
        multLevel2Level.gameObject.SetActive(true);
    }
    public void CloseMultLevel2Level()
    {
        multLevel2Level.gameObject.SetActive(false);
    }
    public void OpenMultLevel2End()
    {
        multLevel2End.gameObject.SetActive(true);
    }
    public void CloseMultLevel2End()
    {
        multLevel2End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Multiply level 3 buttons*/
    public void OpenMultLevel3Canvas()
    {
        multLevel3Canvas.gameObject.SetActive(true);
    }
    public void CloseMultLevel3Canvas()
    {
        multLevel3Canvas.gameObject.SetActive(false);
    }
    public void OpenMultLevel3Start()
    {
        multLevel3Start.gameObject.SetActive(true);
    }
    public void CloseMultLevel3Start()
    {
        multLevel3Start.gameObject.SetActive(false);
    }
    public void OpenMultLevel3Level()
    {
        multLevel3Level.gameObject.SetActive(true);
    }
    public void CloseMultLevel3Level()
    {
        multLevel3Level.gameObject.SetActive(false);
    }
    public void OpenMultLevel3End()
    {
        multLevel3End.gameObject.SetActive(true);
    }
    public void CloseMultLevel3End()
    {
        multLevel3End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Divide level 1 buttons*/
    public void OpenDivLevel1Canvas()
    {
        divLevel1Canvas.gameObject.SetActive(true);
    }
    public void CloseDivLevel1Canvas()
    {
        divLevel1Canvas.gameObject.SetActive(false);
    }
    public void OpenDivLevel1Start()
    {
        divLevel1Start.gameObject.SetActive(true);
    }
    public void CloseDivLevel1Start()
    {
        divLevel1Start.gameObject.SetActive(false);
    }
    public void OpenDivLevel1Level()
    {
        divLevel1Level.gameObject.SetActive(true);
    }
    public void CloseDivLevel1Level()
    {
        divLevel1Level.gameObject.SetActive(false);
    }
    public void OpenDivLevel1End()
    {
        divLevel1End.gameObject.SetActive(true);
    }
    public void CloseDivLevel1End()
    {
        divLevel1End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Divide level 2 buttons*/
    public void OpenDivLevel2Canvas()
    {
        divLevel2Canvas.gameObject.SetActive(true);
    }
    public void CloseDivLevel2Canvas()
    {
        divLevel2Canvas.gameObject.SetActive(false);
    }
    public void OpenDivLevel2Start()
    {
        divLevel2Start.gameObject.SetActive(true);
    }
    public void CloseDivLevel2Start()
    {
        divLevel2Start.gameObject.SetActive(false);
    }
    public void OpenDivLevel2Level()
    {
        divLevel2Level.gameObject.SetActive(true);
    }
    public void CloseDivLevel2Level()
    {
        divLevel2Level.gameObject.SetActive(false);
    }
    public void OpenDivLevel2End()
    {
        divLevel2End.gameObject.SetActive(true);
    }
    public void CloseDivLevel2End()
    {
        divLevel2End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
    }

    /*Divide level 3 buttons*/
    public void OpenDivLevel3Canvas()
    {
        divLevel3Canvas.gameObject.SetActive(true);
    }
    public void CloseDivLevel3Canvas()
    {
        divLevel3Canvas.gameObject.SetActive(false);
    }
    public void OpenDivLevel3Start()
    {
        divLevel3Start.gameObject.SetActive(true);
    }
    public void CloseDivLevel3Start()
    {
        divLevel3Start.gameObject.SetActive(false);
    }
    public void OpenDivLevel3Level()
    {
        divLevel3Level.gameObject.SetActive(true);
    }
    public void CloseDivLevel3Level()
    {
        divLevel3Level.gameObject.SetActive(false);
    }
    public void OpenDivLevel3End()
    {
        divLevel3End.gameObject.SetActive(true);
    }
    public void CloseDivLevel3End()
    {
        divLevel3End.gameObject.SetActive(false);
        stickerbookButton.GetComponent<Animator>().SetBool("StickerSaved", false);
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
