using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    public int nextSceneIndex; // ���� ���� ���� �ε����� �������ּ���
    // public Button bt;

    void Start()
    {
        // bt = gameObject.GetComponent<Button>();
        // bt.onClick.AddListener(StartGame);
        
    }

    public void Button()
    {
        PlayerPrefs.SetInt("correctCount", 0);
        // ���� ���� ���� �ε����� �����ɴϴ�
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // ���� ���� ���� �ε����� ����մϴ�
        int nextSceneIndex = currentSceneIndex + 1;

        // ���� ������ �̵��մϴ�
        SceneManager.LoadScene(nextSceneIndex);
    }
}
