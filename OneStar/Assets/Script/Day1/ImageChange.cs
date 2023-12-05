using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange : MonoBehaviour
{
    public Sprite[] firstSprite;
    public Sprite[] lastSprite;

    public GameObject firstPanel;
    int clickCnt;
    int maxCnt;

    public GameObject panel_1;
    public GameObject panel_2;
    public GameObject panel_3;

    public GameObject btnPanel;
    public GameObject button_1;
    public GameObject button_2;
    public GameObject button_3;

    void Start()
    {
        firstPanel.GetComponent<Image>().sprite = firstSprite[0];
        maxCnt = firstSprite.Length - 1;
        btnPanel.SetActive(false);

        panel_1.SetActive(false);
        panel_2.SetActive(false);
        panel_3.SetActive(false);
    }

    void Update()
    {
        
    }

    public void BtnClick()
    {
        clickCnt++;

        if (clickCnt == 69)
        {
            btnPanel.SetActive(true);
        }

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
        }

        firstPanel.GetComponent<Image>().sprite = firstSprite[clickCnt];
    }

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day1");
    }

    public void Click()
    {
        btnPanel.SetActive(false);

        if (gameObject.tag == "Button1")
        {
            panel_1.SetActive(true);
        } 
        else if(gameObject.tag == "Button2") 
        {
            panel_2.SetActive(true);
        } 
        else 
        {
            panel_3.SetActive(true);
        }
    }
}