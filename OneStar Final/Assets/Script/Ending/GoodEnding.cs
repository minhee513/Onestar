using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoodEnding : MonoBehaviour
{
    public Sprite[] endSprite;
    public GameObject endingPanel;
    public GameObject videoPanel;
    public GameObject VideoPlayer;

    int clickCnt;
    int maxCnt;

    void Start()
    {
        endingPanel.GetComponent<Image>().sprite = endSprite[0];
        maxCnt = endSprite.Length - 1;
        videoPanel.SetActive(false);
        VideoPlayer.SetActive(false);
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
            videoPanel.SetActive(true);
            VideoPlayer.SetActive(true);
        }

        endingPanel.GetComponent<Image>().sprite = endSprite[clickCnt];
    }

    public void GotoMainScene()
    {
        SceneManager.LoadScene(0);
    }
}
