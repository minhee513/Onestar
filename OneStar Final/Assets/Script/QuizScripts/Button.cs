using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonScript : MonoBehaviour
{
    public int nextSceneIndex; // 다음 씬의 빌드 인덱스를 지정해주세요
    // public Button bt;

    void Start()
    {
        // bt = gameObject.GetComponent<Button>();
        // bt.onClick.AddListener(StartGame);
        
    }

    public void Button()
    {
        PlayerPrefs.SetInt("correctCount", 0);
        // 현재 씬의 빌드 인덱스를 가져옵니다
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 다음 씬의 빌드 인덱스를 계산합니다
        int nextSceneIndex = currentSceneIndex + 1;

        // 다음 씬으로 이동합니다
        SceneManager.LoadScene(nextSceneIndex);
    }
}
