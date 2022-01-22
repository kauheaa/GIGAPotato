using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StarCount : MonoBehaviour
{
    public StickerBook book;

    // WORLD
    public int worldIndex;

    // MENU
    public GameObject sumMenuButton, subMenuButton, countMenuButton, multMenuButton, divMenuButton; // Category buttons that change sprites when category is completed
    public Sprite clearButton, completedButton; // Sprite for completed level and category button

    // STARS
    public Sprite noStars, oneStar, twoStar, threeStar; // StarCount sprites
    public GameObject sumStars, sumMenuStars, subStars, subMenuStars, countStars, countMenuStars, multStars, multMenuStars, divStars, divMenuStars; // StarCount object on category title and on category button

    public int sumFarmStarCount, sumJungleStarCount, sumSpaceStarCount;
    public int subFarmStarCount, subJungleStarCount, subSpaceStarCount;
    public int countFarmStarCount, countJungleStarCount, countSpaceStarCount;
    public int multJungleStarCount, multSpaceStarCount;
    public int divJungleStarCount, divSpaceStarCount;

    public void UpdateStarCounts()
    {
        book.UpdateStarCounts();
        sumFarmStarCount = book.sumFarmStarCount;
        sumJungleStarCount = book.sumJungleStarCount;
        sumSpaceStarCount = book.sumSpaceStarCount;
        subFarmStarCount = book.subFarmStarCount;
        subJungleStarCount = book.subJungleStarCount;
        subSpaceStarCount = book.subSpaceStarCount;
        countFarmStarCount = book.countFarmStarCount;
        countJungleStarCount = book.countJungleStarCount;
        countSpaceStarCount = book.countSpaceStarCount;
        multJungleStarCount = book.multJungleStarCount;
        multSpaceStarCount = book.multSpaceStarCount;
        divJungleStarCount = book.divJungleStarCount;
        divSpaceStarCount = book.divSpaceStarCount;
    }

    public void SumStarCount() // Counts and updates sum stars
    {
        UpdateStarCounts();
        //Debug.Log("Stars counted");
        switch (worldIndex)
        {
            case 1:
                switch (sumFarmStarCount)
                {
                    case 0:
                        sumStars.GetComponent<Image>().sprite = noStars;
                        sumMenuStars.GetComponent<Image>().sprite = noStars;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        sumStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;

                    case 2:
                        sumStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        sumStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 2:
                switch (sumJungleStarCount)
                {
                    case 0:
                        sumStars.GetComponent<Image>().sprite = noStars;
                        sumMenuStars.GetComponent<Image>().sprite = noStars;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        sumStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;

                    case 2:
                        sumStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        sumStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 3:
                switch (sumSpaceStarCount)
                {
                    case 0:
                        sumStars.GetComponent<Image>().sprite = noStars;
                        sumMenuStars.GetComponent<Image>().sprite = noStars;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        sumStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuStars.GetComponent<Image>().sprite = oneStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        sumStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuStars.GetComponent<Image>().sprite = twoStar;
                        sumMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        sumStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuStars.GetComponent<Image>().sprite = threeStar;
                        sumMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            default:
                //Debug.Log("No world index set");
                break;
        }
    }
    public void SubStarCount() // Counts and updates sub stars
    {
        UpdateStarCounts();
        //Debug.Log("Stars counted");
        switch (worldIndex)
        {
            case 1:
                switch (subFarmStarCount)
                {
                    case 0:
                        subStars.GetComponent<Image>().sprite = noStars;
                        subMenuStars.GetComponent<Image>().sprite = noStars;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        subStars.GetComponent<Image>().sprite = oneStar;
                        subMenuStars.GetComponent<Image>().sprite = oneStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;

                    case 2:
                        subStars.GetComponent<Image>().sprite = twoStar;
                        subMenuStars.GetComponent<Image>().sprite = twoStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        subStars.GetComponent<Image>().sprite = threeStar;
                        subMenuStars.GetComponent<Image>().sprite = threeStar;
                        subMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 2:
                switch (subJungleStarCount)
                {
                    case 0:
                        subStars.GetComponent<Image>().sprite = noStars;
                        subMenuStars.GetComponent<Image>().sprite = noStars;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        subStars.GetComponent<Image>().sprite = oneStar;
                        subMenuStars.GetComponent<Image>().sprite = oneStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;

                    case 2:
                        subStars.GetComponent<Image>().sprite = twoStar;
                        subMenuStars.GetComponent<Image>().sprite = twoStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        subStars.GetComponent<Image>().sprite = threeStar;
                        subMenuStars.GetComponent<Image>().sprite = threeStar;
                        subMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 3:
                switch (subSpaceStarCount)
                {
                    case 0:
                        subStars.GetComponent<Image>().sprite = noStars;
                        subMenuStars.GetComponent<Image>().sprite = noStars;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        subStars.GetComponent<Image>().sprite = oneStar;
                        subMenuStars.GetComponent<Image>().sprite = oneStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        subStars.GetComponent<Image>().sprite = twoStar;
                        subMenuStars.GetComponent<Image>().sprite = twoStar;
                        subMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        subStars.GetComponent<Image>().sprite = threeStar;
                        subMenuStars.GetComponent<Image>().sprite = threeStar;
                        subMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            default:
                //Debug.Log("No world index set");
                break;
        }
    }
    public void CountStarCount() // Counts and updates count stars
    {
        UpdateStarCounts();
        //Debug.Log("Stars counted");
        switch (worldIndex)
        {
            case 1:
                switch (countFarmStarCount)
                {
                    case 0:
                        countStars.GetComponent<Image>().sprite = noStars;
                        countMenuStars.GetComponent<Image>().sprite = noStars;
                        countMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        countStars.GetComponent<Image>().sprite = oneStar;
                        countMenuStars.GetComponent<Image>().sprite = oneStar;
                        countMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        countStars.GetComponent<Image>().sprite = twoStar;
                        countMenuStars.GetComponent<Image>().sprite = twoStar;
                        countMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        countStars.GetComponent<Image>().sprite = threeStar;
                        countMenuStars.GetComponent<Image>().sprite = threeStar;
                        countMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            //case 2:
            //    switch (countJungleStarCount)
            //    {
            //        case 0:
            //            countStars.GetComponent<Image>().sprite = noStars;
            //            countMenuStars.GetComponent<Image>().sprite = noStars;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 1:
            //            countStars.GetComponent<Image>().sprite = oneStar;
            //            countMenuStars.GetComponent<Image>().sprite = oneStar;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 2:
            //            countStars.GetComponent<Image>().sprite = twoStar;
            //            countMenuStars.GetComponent<Image>().sprite = twoStar;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 3:
            //            countStars.GetComponent<Image>().sprite = threeStar;
            //            countMenuStars.GetComponent<Image>().sprite = threeStar;
            //            countMenuButton.GetComponent<Image>().sprite = completedButton;
            //            break;
            //    }
            //    break;
            //case 3:
            //    switch (countSpaceStarCount)
            //    {
            //        case 0:
            //            countStars.GetComponent<Image>().sprite = noStars;
            //            countMenuStars.GetComponent<Image>().sprite = noStars;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 1:
            //            countStars.GetComponent<Image>().sprite = oneStar;
            //            countMenuStars.GetComponent<Image>().sprite = oneStar;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 2:
            //            countStars.GetComponent<Image>().sprite = twoStar;
            //            countMenuStars.GetComponent<Image>().sprite = twoStar;
            //            countMenuButton.GetComponent<Image>().sprite = clearButton;
            //            break;
            //        case 3:
            //            countStars.GetComponent<Image>().sprite = threeStar;
            //            countMenuStars.GetComponent<Image>().sprite = threeStar;
            //            countMenuButton.GetComponent<Image>().sprite = completedButton;
            //            break;
            //    }
            //    break;
            default:
                //Debug.Log("No world index set");
                break;
        }
    }
    public void MultStarCount() // Counts and updates mult stars
    {
        UpdateStarCounts();
        //Debug.Log("Stars counted");
        switch (worldIndex)
        {
            case 1:
                //Debug.Log("No mult levels in Farm");
                break;
            case 2:
                switch (multJungleStarCount)
                {
                    case 0:
                        multStars.GetComponent<Image>().sprite = noStars;
                        multMenuStars.GetComponent<Image>().sprite = noStars;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        multStars.GetComponent<Image>().sprite = oneStar;
                        multMenuStars.GetComponent<Image>().sprite = oneStar;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        multStars.GetComponent<Image>().sprite = twoStar;
                        multMenuStars.GetComponent<Image>().sprite = twoStar;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        multStars.GetComponent<Image>().sprite = threeStar;
                        multMenuStars.GetComponent<Image>().sprite = threeStar;
                        multMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 3:
                switch (multSpaceStarCount)
                {
                    case 0:
                        multStars.GetComponent<Image>().sprite = noStars;
                        multMenuStars.GetComponent<Image>().sprite = noStars;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        multStars.GetComponent<Image>().sprite = oneStar;
                        multMenuStars.GetComponent<Image>().sprite = oneStar;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        multStars.GetComponent<Image>().sprite = twoStar;
                        multMenuStars.GetComponent<Image>().sprite = twoStar;
                        multMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        multStars.GetComponent<Image>().sprite = threeStar;
                        multMenuStars.GetComponent<Image>().sprite = threeStar;
                        multMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            default:
                //Debug.Log("No world index set");
                break;
        }
    }
    public void DivStarCount() // Counts and updates div stars
    {
        UpdateStarCounts();
        //Debug.Log("Stars counted");
        switch (worldIndex)
        {
            case 1:
                //Debug.Log("No div levels in Farm");
                break;
            case 2:
                switch (divJungleStarCount)
                {
                    case 0:
                        divStars.GetComponent<Image>().sprite = noStars;
                        divMenuStars.GetComponent<Image>().sprite = noStars;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        divStars.GetComponent<Image>().sprite = oneStar;
                        divMenuStars.GetComponent<Image>().sprite = oneStar;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        divStars.GetComponent<Image>().sprite = twoStar;
                        divMenuStars.GetComponent<Image>().sprite = twoStar;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        divStars.GetComponent<Image>().sprite = threeStar;
                        divMenuStars.GetComponent<Image>().sprite = threeStar;
                        divMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            case 3:
                switch (divSpaceStarCount)
                {
                    case 0:
                        divStars.GetComponent<Image>().sprite = noStars;
                        divMenuStars.GetComponent<Image>().sprite = noStars;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 1:
                        divStars.GetComponent<Image>().sprite = oneStar;
                        divMenuStars.GetComponent<Image>().sprite = oneStar;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 2:
                        divStars.GetComponent<Image>().sprite = twoStar;
                        divMenuStars.GetComponent<Image>().sprite = twoStar;
                        divMenuButton.GetComponent<Image>().sprite = clearButton;
                        break;
                    case 3:
                        divStars.GetComponent<Image>().sprite = threeStar;
                        divMenuStars.GetComponent<Image>().sprite = threeStar;
                        divMenuButton.GetComponent<Image>().sprite = completedButton;
                        break;
                }
                break;
            default:
                //Debug.Log("No world index set");
                break;
        }
    }

    public void CountStars()
    {
        SumStarCount();
        SubStarCount();
        CountStarCount();
        MultStarCount();
        DivStarCount();
    }

    void Start()
    {
        CountStars();
    }

    void Update()
    {
    }
}