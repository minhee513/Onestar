using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange3 : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject panel;
    int clickCnt;
    int maxCnt;

    public string currentSprite;
    public GameObject button1, button2;

    AudioSource[] day3Audio;


    void Awake()
    {
        day3Audio = GetComponents<AudioSource>();
    }

    void Start()
    {
        panel.GetComponent<Image>().sprite = sprites[0];
        maxCnt = sprites.Length - 1;
    }

    void Update()
    {
        currentSprite = panel.GetComponent<Image>().sprite.name;
        if (currentSprite == "Day3.14")
        {
            button1.SetActive(true);
            button2.SetActive(true);
        }
        else
        {
            button1.SetActive(false);
            button2.SetActive(false);
        }
    }

    public void BtnClick()
    {
        if (currentSprite != "Day3.14") { clickCnt++;}

        if (clickCnt == 8)
        {
            day3Audio[1].Play();
        }

        if (clickCnt == 11)
        {
            day3Audio[1].Stop();
        }

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
            if (clickCnt == 0)
            {
                SceneManager.LoadScene("Day4");
            }
        }

        if(currentSprite == "Day3.16")
        {
            SceneManager.LoadScene("Day4");
        }

        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day3");
    }

    public void Button1()
    {
        clickCnt++;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    public void Button2()
    {
        clickCnt += 3;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

}