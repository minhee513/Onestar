using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private static Score instance;

    private string scoreKey = "PlayerScore";
    public int goodEndingScore = 10;
    public int badEndingScore = 7;

    private int currentScore = 0;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        currentScore = PlayerPrefs.GetInt(scoreKey, 0);
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        currentScore += GetScoreForButtonClick();

        if(currentScore <= badEndingScore)
        {
            SceneManager.LoadScene(0);

        }
        else if(currentScore >= goodEndingScore)
        {
            SceneManager.LoadScene(1);  // ¹èµå ¿£µù¾À
        }
    } 

    public int GetScoreForButtonClick()
    {
        int buttonScore = 0;

        if (gameObject.tag == "Button1")
        {
            buttonScore = 1;
        }

        if (gameObject.tag == "Button2")
        {
            buttonScore = 2;
        }

        if (gameObject.tag == "Button2")
        {
            buttonScore = 3;
        }

        PlayerPrefs.SetInt(scoreKey, buttonScore);
        PlayerPrefs.Save();

        return buttonScore;
    }
}
