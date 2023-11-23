using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    // public Sprite[] sprites;
    // public GameObject panel;
    // int clickCnt;
    // int maxCnt;

    void Start()
    {
        // panel.GetComponent<Image>().sprite = sprites[0];
        // maxCnt = sprites.Length - 1;
    }

    void Update()
    {
        
    }

    /*
    public void BtnClick()
    {
        clickCnt++;

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
        }

        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }
    */

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day1");

        if ()
        {

        }
    }
}