using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackgroundOnEvent : MonoBehaviour
{
    public Sprite Class;
    public Sprite Hallway;
    public Sprite Outside;
    public Sprite LectureHall;
    public Sprite DinningHall;
    [Space(10)]
    public string DefaultName;//name of the default background
    [Space(10)]
    public GameObject ChildWithSprite;

    void Start()
    {
        if (DefaultName == "Class")
        {
            ChildWithSprite.GetComponent<Image>().sprite = Class;
        }
        else if (DefaultName == "Hallway")
        {
            ChildWithSprite.GetComponent<Image>().sprite = Hallway;
        }
        else if (DefaultName == "Outside")
        {
            ChildWithSprite.GetComponent<Image>().sprite = Outside;
        }
        else if (DefaultName == "LectureHall")
        {
            ChildWithSprite.GetComponent<Image>().sprite = LectureHall;
        }
        else if (DefaultName == "DinningHall")
        {
            ChildWithSprite.GetComponent<Image>().sprite = DinningHall;
        }
    }

    public void BackgroundClass()
    {
        ChildWithSprite.GetComponent<Image>().sprite = Class;
    }
    public void BackgroundHallway()
    {
        ChildWithSprite.GetComponent<Image>().sprite = Hallway;
    }
    public void BackgroundOutside()
    {
        ChildWithSprite.GetComponent<Image>().sprite = Outside;
    }
    public void BackgroundLectureHall()
    {
        ChildWithSprite.GetComponent<Image>().sprite = LectureHall;
    }
    public void BackgroundDinningHall()
    {
        ChildWithSprite.GetComponent<Image>().sprite = DinningHall;
    }
}
