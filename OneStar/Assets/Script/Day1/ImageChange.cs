using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject panel;
    int clickCnt;
    int maxCnt;

    void Start()
    {
        panel.GetComponent<Image>().sprite = sprites[0];
        maxCnt = sprites.Length - 1;
    }

    void Update()
    {
        
    }

    public void BtnClick()
    {
        clickCnt++;

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
            if (clickCnt == 0)
            {
                SceneManager.LoadScene(0);
            }
        }

        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day1");
    }
}