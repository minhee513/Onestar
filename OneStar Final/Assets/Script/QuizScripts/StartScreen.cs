using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public UnityEngine.UI.Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame); //다음 화면으로 넘어가는 버튼

        PlayerPrefs.DeleteAll(); // 게임을 시작하면서 이전 게임에서 퀴즈를 몇개 맞췄는지 알려주는 변수의 초기화
    }

    void StartGame()
    {
        SceneManager.LoadScene("메인화면");
    }

    void Update()
    {

    }
}
