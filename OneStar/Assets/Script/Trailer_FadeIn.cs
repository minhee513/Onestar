using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trailer_FadeIn : MonoBehaviour
{

    public Image image;
    public GameObject button;
    public int whatNextScene;

    public void FadeButton()
    {
        button.SetActive(false);
        StartCoroutine(FadeCoroutine());
        Invoke("Go_Prologue", 2f);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;

        while (fadeCount < 1.0f)
        {
            fadeCount += 0.005f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);
        }
    }

    public void Go_Prologue()
    {
        SceneManager.LoadScene(1);
    }
}
