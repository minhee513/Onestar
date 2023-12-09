using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quiz1 : MonoBehaviour
{


    private int correctCount;
    public GameObject titleText;
    public GameObject correctPopup;
    public GameObject wrongPopup;
    public Button oButton;
    public Button xButton;
    public AudioSource audioSource; // AudioSource 컴포넌트를 담을 변수
    public AudioClip oButtonSound; // O 버튼 소리를 담을 AudioClip 변수
    public AudioClip xButtonSound; // X 버튼 소리를 담을 AudioClip 변수

    
    public GameObject quiz2Object; // Quiz2 오브젝트를 담을 변수

    private void Start()
    {
        correctCount = PlayerPrefs.GetInt("correctCount", 0);

        oButton.onClick.AddListener(OnOButtonClick);
        xButton.onClick.AddListener(OnXButtonClick);

        correctPopup.SetActive(false);
        wrongPopup.SetActive(false);
    }

    private void OnOButtonClick()
    {
        
        PlayButtonSound(oButtonSound); // O 버튼 소리 재생
        ShowCorrectPopup();

        correctCount++;
        PlayerPrefs.SetInt("correctCount", correctCount); // 변수저장
       
    }

    private void OnXButtonClick()
    {
        PlayButtonSound(xButtonSound); // X 버튼 소리 재생
        ShowWrongPopup();
    }

    private void ShowCorrectPopup()
    {
        
        correctPopup.SetActive(true);
        wrongPopup.SetActive(false);
        StartCoroutine(DelayedHidePopup(correctPopup));
        StartCoroutine(ShowQuiz2Object());
    }

    private void ShowWrongPopup()
    {
        correctPopup.SetActive(false);
        wrongPopup.SetActive(true);
        StartCoroutine(DelayedHidePopup(wrongPopup));
        StartCoroutine(ShowQuiz2Object());
    }

    private System.Collections.IEnumerator DelayedHidePopup(GameObject popup)
    {
        yield return new WaitForSeconds(1.5f);
        popup.SetActive(false);
    }

    private System.Collections.IEnumerator ShowQuiz2Object()
    {
        yield return new WaitForSeconds(1.5f);
     
            gameObject.SetActive(false); // Quiz1 오브젝트 비활성화
            quiz2Object.SetActive(true); // Quiz2 오브젝트 활성화
       
    }

    private void PlayButtonSound(AudioClip sound)
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource가 할당되지 않았습니다. 인스펙터에서 audioSource를 설정해주세요.");
            return;
        }

        audioSource.clip = sound; // AudioSource의 clip을 설정하여 원하는 소리를 할당합니다.
        audioSource.Play(); // 버튼 소리 재생
    }
}
