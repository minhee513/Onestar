using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageChange5 : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject panel;
    int clickCnt;
    int maxCnt;
    public int changeCount = 0;

    public string currentSprite;


    private void Awake()
    {
        //ImageChange2 스크립트가 붙어있는 오브젝트를 찾는다
        var obj = Object.FindObjectsOfType<ImageChange5>();

        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        panel = GameObject.Find("Panel");

        panel.GetComponent<Image>().sprite = sprites[0];
        maxCnt = sprites.Length - 1;
    }

    void Update()
    {
        if(!(panel == null))
        {
            currentSprite = panel.GetComponent<Image>().sprite.name;

            if (currentSprite == "Day5.9")
            {
                if (Input.GetMouseButtonDown(0) && changeCount == 0)
                {
                    SceneManager.LoadScene("QuizMain");
                    changeCount++;
                }
            }
        }

        if (SceneManager.GetActiveScene().name == "Day5" && panel == null)
        {
            panel = GameObject.Find("Panel");
            panel.GetComponent<Image>().sprite = sprites[clickCnt];
        }

        if(SceneManager.GetActiveScene().name == "Day5")
            ChangeSprite();
    }

    public void ChangeSprite()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCnt++;

            if (clickCnt > maxCnt)
            {
                clickCnt = 0;
                if (clickCnt == 0)
                {
                    SceneManager.LoadScene("Ending");
                    Destroy(gameObject);
                }
            }
            if(currentSprite == "Day5.9")
            {
                SceneManager.LoadScene("QuizMain");
            }
        if (panel != null)
                panel.GetComponent<Image>().sprite = sprites[clickCnt];
        }
    }


    /* public void BtnClick()
    {
        clickCnt++;

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
            if (clickCnt == 0)
            {
                SceneManager.LoadScene("Ending");
            }
        }
        if(panel != null)
            panel.GetComponent<Image>().sprite = sprites[clickCnt];
    } */

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day5");
    }

}