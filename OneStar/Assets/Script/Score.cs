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
        currentScore = PlayerPrefs.GetInt(scoreKey, 0);
    }

    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        currentScore += GetScoreForButtonClick();

        if(currentScore < 5)
        {
            SceneManager.LoadScene(0);

        } 
        else if(currentScore == badEndingScore)
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

        return buttonScore;
    }
}
