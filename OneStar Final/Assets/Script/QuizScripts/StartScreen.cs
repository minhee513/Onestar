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
        startButton.onClick.AddListener(StartGame); //���� ȭ������ �Ѿ�� ��ư

        PlayerPrefs.DeleteAll(); // ������ �����ϸ鼭 ���� ���ӿ��� ��� � ������� �˷��ִ� ������ �ʱ�ȭ
    }

    void StartGame()
    {
        SceneManager.LoadScene("����ȭ��");
    }

    void Update()
    {

    }
}
