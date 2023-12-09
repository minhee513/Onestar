using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange : MonoBehaviour
{
    public Sprite[] firstSprite;
    public Sprite[] lastSprite;
    AudioSource[] day1Audio;

    public GameObject firstPanel;
    int clickCnt;
    int maxCnt;

    public GameObject panel_1;
    public GameObject panel_2;
    public GameObject panel_3;
    public GameObject panel_4;

    public GameObject btnPanel;
    public GameObject button_1;
    public GameObject button_2;
    public GameObject button_3;

    void Awake()
    {
        day1Audio = GetComponents<AudioSource>();
    }

    void Start()
    {
        firstPanel.GetComponent<Image>().sprite = firstSprite[0];
        maxCnt = firstSprite.Length - 1;
        btnPanel.SetActive(false);

        panel_1.SetActive(false);
        panel_2.SetActive(false);
        panel_3.SetActive(false);
        panel_4.SetActive(false);
    }

    void Update()
    {
        
    }

    public void BtnClick()
    {
        clickCnt++;

        if(clickCnt == 31)
        {
            day1Audio[0].Stop();
            day1Audio[1].Play();
        }
        
        if (clickCnt == 43)
        {
            day1Audio[1].Stop();
            day1Audio[0].Play();
        }

        if (clickCnt == 73)
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

    public void Button1Click()
    {
        panel_1.SetActive(true);
    }

    public void Button2Click()
    {
        panel_2.SetActive(true);
    }

    public void Button3Click()
    {
        panel_3.SetActive(true);
    }

    public void Panel4Appear()
    {
        panel_4.SetActive(true);
    }

    public void Day2Click()
    {

        SceneManager.LoadScene(4);
    }
}