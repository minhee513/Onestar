using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TrailerDialogue : MonoBehaviour
{
    public TMP_Text TrailerText;    // 변경할 트레일러 텍스트

    // string dialogue;

    public string[] T_Dialogue; // 트레일러 대사 저장 배열
    public string[] dialogues;  // StartTalk 함수에서 매개변수 저장하는 배열

    int curDialogueIdx = 0; // 다음 대사 출력을 위한 정수

    public GameObject p_Panel;

    Renderer render;
    public GameObject prologueText;
    
    AudioSource[] BGM;

    // public Image image;

    // public GameObject Fadein;

    void Awake()
    {
        BGM = GetComponents<AudioSource>(); // BGM 컴포넌트 설정
        render = prologueText.GetComponent<Renderer>();
        // Fadein.GetComponent<Trailer_FadeIn>().FadeButton();
    }

    void Start()
    {
        StartTalk(T_Dialogue);
        p_Panel.SetActive(false);
    }

    void Update()
    {
        
    }

    public void StartTalk(string[] trailers)
    {
        dialogues = trailers;

        // curDialogueIdx번째 대사 출력
        StartCoroutine(Typing(dialogues[curDialogueIdx]));
    }

    public void NextTrailer()
    {
        TrailerText.text = null;    // 텍스트 박스 초기화
        curDialogueIdx++;   // 다음 배열 출력을 위해 +1

        // curDialogueIdx이 배열의 길이와 같으면 종료
        if (curDialogueIdx == dialogues.Length)
        {
            EndTalk();
            return;
        }

        StartCoroutine(Typing(dialogues[curDialogueIdx]));
    }

    public void EndTalk()
    {
        // curDialogueIdx 초기화
        curDialogueIdx = 0;
        Debug.Log("트레일러 끝");

        // curDialogueIdx이 0이면 씬 변경
        if (curDialogueIdx == 0)
        {
            // BGM[0].Stop();
            BGM[1].Stop();
            p_Panel.SetActive(true);
            prologueText.SetActive(false);
            StartCoroutine(TextAppear());
        }
    }

    IEnumerator Typing(string trailer)
    {
        TrailerText.text = null;    // 텍스트 박스 초기화

        // 글자 길이만큼 반복
        for (int i = 0; i < trailer.Length; i++)
        {
            TrailerText.text += trailer[i];
            BGM[1].Play();  // 텍스트 타이핑 효과음 출력

            // 속도
            yield return new WaitForSeconds(0.05f); // 타이핑 딜레이 시간, 원하는 시간으로 설정 가능
        }

        // 다음 대사 딜레이
        yield return new WaitForSeconds(1.5f);
        NextTrailer();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    /*
    public void TextAppear()
    {
        FadeIn();
        SceneManager.LoadScene(1);
    }
    */

    IEnumerator TextAppear()
    {

        yield return new WaitForSeconds(1f);
        prologueText.SetActive(true);
    }
}

[System.Serializable]
public class TrailerData
{
    public string Trailer;
}
