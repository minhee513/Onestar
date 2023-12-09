using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange4 : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject panel;
    int clickCnt;
    int maxCnt;

    public string currentSprite;
    public GameObject button1, button2, button3;


    void Start()
    {
        panel.GetComponent<Image>().sprite = sprites[0];
        maxCnt = sprites.Length - 1;
    }

    void Update()
    {
        currentSprite = panel.GetComponent<Image>().sprite.name;
        if (currentSprite == "Day4.10")
        {
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
        }
        else
        {
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
        }
    }

    public void BtnClick()
    {
        if (currentSprite != "Day4.10") { clickCnt++; }
        

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
            if (clickCnt == 0)
            {
                SceneManager.LoadScene("Day5");
            }
        }

        if (currentSprite == "Day4.11.3")
        {
            clickCnt += 6;
            panel.GetComponent<Image>().sprite = sprites[clickCnt];
        }

        if (currentSprite == "Day4.12.2")
        {
            clickCnt += 4;
            panel.GetComponent<Image>().sprite = sprites[clickCnt];
        }



        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day4");
    }

    public void Button1()
    {
        clickCnt++;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    public void Button2()
    {
        clickCnt += 4;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    public void Button3()
    {
        clickCnt += 6;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }
}