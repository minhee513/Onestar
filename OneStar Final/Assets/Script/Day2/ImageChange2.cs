using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using TMPro;
using UnityEngine.Video;

public class ImageChange2 : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject panel;
    public int clickCnt;
    public int maxCnt;
    public int changeCount = 0;
    public int changeCnt1 = 0;

    public string txt1;
    public string txt2;
    public TMP_Text target1;
    public TMP_Text target2;
    public float delay = 0.08f;
    public bool isStart1 = false;
    public bool isStart2 = false;

    public GameObject vd;
    public VideoPlayer clip;
    public int count = 0;

    public string currentSprite;
    public GameObject button1, button2, button3, text1, text2;
    [SerializeField]
    public Button bt1,bt2,bt3;
    private GameObject instance;

    //Start보다 먼저 작동
    private void Awake()
    {
        //ImageChange2 스크립트가 붙어있는 오브젝트를 찾는다
        var obj = Object.FindObjectsOfType<ImageChange2>();

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
        button1 = GameObject.Find("Button");
        button2 = GameObject.Find("Button1");
        button3 = GameObject.Find("Button2");
        text1 = GameObject.Find("Text1");
        text2 = GameObject.Find("Text2");
        target1 = text1.GetComponent<TMP_Text>();
        target2 = text2.GetComponent<TMP_Text>();

        vd = GameObject.Find("Panel2");
        clip = GameObject.Find("Video Player").GetComponent<VideoPlayer>();

/*        bt1 = button1.gameObject.GetComponent<Button>();
        bt1.onClick.AddListener(Button1);*/

        panel.SetActive(true);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        vd.SetActive(false);

        bt1 = button1.gameObject.GetComponent<Button>();
        bt2 = button2.gameObject.GetComponent<Button>();
        bt3 = button3.gameObject.GetComponent<Button>();

        bt1.onClick.AddListener(Button1);
        bt2.onClick.AddListener(Button2);
        bt3.onClick.AddListener(Button3);

        panel.GetComponent<Image>().sprite = sprites[0];

        maxCnt = sprites.Length - 1;


        txt1 = target1.text.ToString();
        target1.text = "";
        txt2 = target2.text.ToString();
        target2.text = "";
        
    }

    void Update()
    {
        if (!(panel == null))
        {


            if(panel.GetComponent<Image>().sprite != null)
                currentSprite = panel.GetComponent<Image>().sprite.name;

            if (currentSprite == "Day2.17")
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

            if (currentSprite == "Day2.18.2")
            {
                text1.SetActive(true);
            }
            else
            {
                text1.SetActive(false);
            }

            if (currentSprite == "Day2.20.2")
            {
                text2.SetActive(true);
            }
            else
            {
                text2.SetActive(false);
            }

            if (currentSprite == "Day2.2")  // 리듬게임 넣기
            {
                if (Input.GetMouseButtonDown(0) && changeCount == 0)
                {
                    //SceneManager.LoadScene("StartMain");
                    SceneManager.LoadScene("StartMain");
                    changeCount++;
                }
            }

            if(currentSprite == "Day2.12" && count == 0)
            {
                vd.SetActive(true);                
                panel.SetActive(false);
                clip.Play();
                UnityEngine.Debug.Log("동영상 플레이");
                count++;
            }

            if (!clip.isPlaying && Input.GetMouseButtonDown(0) && count == 1)
            {
                vd.SetActive(false);
                panel.SetActive(true);
                count++;
                UnityEngine.Debug.Log("동영상 끝나고 다음 장면");
            }
        }
        if(SceneManager.GetActiveScene().name == "Day2") ChangeSprite();

        


        if (SceneManager.GetActiveScene().name == "Day2" && panel == null)
        {
            panel = GameObject.Find("Panel");
            button1 = GameObject.Find("Button");
            button2 = GameObject.Find("Button1");
            button3 = GameObject.Find("Button2");
            text1 = GameObject.Find("Text1");
            text2 = GameObject.Find("Text2");
            target1 = text1.GetComponent<TMP_Text>();
            target2 = text2.GetComponent<TMP_Text>();
            vd = GameObject.Find("Panel2");
            clip = GameObject.Find("Video Player").GetComponent<VideoPlayer>();

            target1.text = "";
            target2.text = "";



            panel.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            text1.SetActive(false);
            text2.SetActive(false);
            vd.SetActive(false);


            bt1 = button1.gameObject.GetComponent<Button>();
            bt2 = button2.gameObject.GetComponent<Button>();
            bt3 = button3.gameObject.GetComponent<Button>();

            bt1.onClick.AddListener(Button1);
            bt2.onClick.AddListener(Button2);
            bt3.onClick.AddListener(Button3);

            panel.GetComponent<Image>().sprite = sprites[clickCnt];
        }

        if(currentSprite == "Day2.18.2" && !isStart1)
        {
            isStart1 = true;
            
            StartCoroutine(textprint(delay,txt1,target1));
        }
        else if (currentSprite == "Day2.20.2" && !isStart2)
        {
            isStart2 = true;
            
            StartCoroutine(textprint(delay, txt2,target2));
        }
        

        /*if (currentSprite == "Day2.17")
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

        if (currentSprite == "Day2.18.2")
        {
            text1.SetActive(true);
        }
        else
        {
            text1.SetActive(false);
        }

        if (currentSprite == "Day2.20.2")
        {
            text2.SetActive(true);
        }
        else
        {
            text2.SetActive(false);
        }

        if(currentSprite == "Day2.2")  // 리듬게임 넣기
        {
            if (Input.GetMouseButtonDown(0))
            {
                //SceneManager.LoadScene("StartMain");
                SceneManager.LoadScene("1");
            }
        }
        if (currentSprite == "Day2.1" && Data.count1 != 0)
        {
            clickCnt = 3;
        }*/
    }

    IEnumerator textprint(float delay, string text, TMP_Text target)
    {
        int count = 0;
        while (count != text.Length)
        {
            if (count < text.Length)
            {
                target.text += text[count].ToString();
                count++;
            }
            yield return new WaitForSeconds(delay);
        }

    }

    public void ChangeSprite()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentSprite != "Day2.17")
            {
                clickCnt++;
            }


            if (clickCnt > maxCnt)
            {
                clickCnt = 0;
                if (clickCnt == 0)
                {
                    SceneManager.LoadScene("Day3");
                    Destroy(gameObject);
                }
            }

            if (currentSprite == "Day2.18.5" || currentSprite == "Day2.19.2")
            {
                SceneManager.LoadScene("Day3");
                Destroy(gameObject);
            }

            if (panel != null)
                panel.GetComponent<Image>().sprite = sprites[clickCnt];

            DelayCoroution(1f);
        }
    }

    IEnumerator DelayCoroution(float d)
    {
        yield return new WaitForSeconds(d);
    }

    public void BtnClick()
    {
        if (currentSprite != "Day2.17") 
        { 
            clickCnt++;
        }
        

        if (clickCnt > maxCnt)
        {
            clickCnt = 0;
            if (clickCnt == 0)
            {
                SceneManager.LoadScene("Day3");
            }
        }

        if (currentSprite == "Day2.18.5" || currentSprite == "Day2.19.2")
        {
            SceneManager.LoadScene("Day3");
        }



        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    void SpriteImage()
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>("Day2");
    }

    public void Button1()
    {
        UnityEngine.Debug.Log("Button1()");
        clickCnt++;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    public void Button2()
    {
        UnityEngine.Debug.Log("Button2()");
        clickCnt += 6;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

    public void Button3()
    {
        UnityEngine.Debug.Log("Button3()");
        clickCnt += 8;
        panel.GetComponent<Image>().sprite = sprites[clickCnt];
    }

}