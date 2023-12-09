using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quiz3 : MonoBehaviour
{
    private int correctCount;


    public GameObject titleText;
    public GameObject correctPopup;
    public GameObject wrongPopup;
    public Button oButton;
    public Button xButton;
    public AudioSource audioSource;

    public AudioClip oButtonSound; // O ��ư �Ҹ��� ���� AudioClip ����
    public AudioClip xButtonSound; // X ��ư �Ҹ��� ���� AudioClip ����
    public AudioClip quiz3Sound;

    public GameObject quiz4Object; // Quiz3 ������Ʈ�� ���� ����

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
        PlayButtonSound(oButtonSound); // O ��ư �Ҹ� ���
        ShowCorrectPopup();
        correctCount++;
        PlayerPrefs.SetInt("correctCount", correctCount);
        
    }

    private void OnXButtonClick()
    {
        PlayButtonSound(xButtonSound); // X ��ư �Ҹ� ���
        ShowWrongPopup();
    }

    private void ShowCorrectPopup()
    {
        
        correctPopup.SetActive(true);
        wrongPopup.SetActive(false);
        StartCoroutine(DelayedHidePopup(correctPopup));
        StartCoroutine(ShowQuiz4Object());
    }

    private void ShowWrongPopup()
    {
        correctPopup.SetActive(false);
        wrongPopup.SetActive(true);
        StartCoroutine(DelayedHidePopup(wrongPopup));
        StartCoroutine(ShowQuiz4Object());
    }

    private System.Collections.IEnumerator DelayedHidePopup(GameObject popup)
    {
        yield return new WaitForSeconds(1.5f);
        popup.SetActive(false);
    }

    private System.Collections.IEnumerator ShowQuiz4Object()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false); // Quiz2 ������Ʈ ��Ȱ��ȭ
        quiz4Object.SetActive(true); // Quiz3 ������Ʈ Ȱ��ȭ
    }

    private void PlayButtonSound(AudioClip sound)
    {
        if (audioSource == null)
        {
            Debug.LogError("AudioSource�� �Ҵ���� �ʾҽ��ϴ�. �ν����Ϳ��� audioSource�� �������ּ���.");
            return;
        }

        audioSource.clip = sound; // AudioSource�� clip�� �����Ͽ� ���ϴ� �Ҹ��� �Ҵ��մϴ�.
        audioSource.Play(); // ��ư �Ҹ� ���
    }

}
