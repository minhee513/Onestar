using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public DialogueData[] dialogueDatas;    // 대사 저장 변수
    public NarrationData[] narrationDatas;  // 나레이션 저장 변수

    public GameObject nPanel;
    public GameObject dPanel;   // Dialogue 패널
    public GameObject appear;   // Dialogue 패널 버튼
    public GameObject gPanel;   // 게임 화면 패널

    public TMP_Text nameText;   // 이름
    public TMP_Text dialogueText;   // 대사

    public TMP_Text narrationText;  // 나레이션


    private void Start()
    {
        nameText.text = ""; // 이름 텍스트 
        dialogueText.text = ""; // 대화 텍스트

        narrationText.text = "";

        nPanel.SetActive(false);
        appear.SetActive(false);
        dPanel.SetActive(false);
        gPanel.SetActive(false);
    }

    int curDialogueIdx = 0; // 대화 개수 체크
    int curNarrationIdx = 0; // 나레이션 개수 체크

    private void Update()
    {

        // 마우스 클릭 체크
        if (Input.GetMouseButtonDown(0))
        {
            nPanel.SetActive(true);
            NextNarration();
        }
    }

    public void NextNarration()
    {
        if (narrationDatas.Length <= curNarrationIdx)
        {
            // 대화 없음
            appear.SetActive(true);
            return;
        }

        narrationText.text = narrationDatas[curNarrationIdx].narration; // 나레이션 배열에 저장된 텍스트
        curNarrationIdx++;
    }

    public void AppearDPanel()
    {
            nPanel.SetActive(false);
            dPanel.SetActive(true);
            NextDialogue();
    }

    public void NextDialogue()
    {
        if (dialogueDatas.Length <= curDialogueIdx)
        {
            gPanel.SetActive(true);
            return;
        }

        nameText.text = dialogueDatas[curDialogueIdx].name; // 다이얼로그 배열에 저장된 이름 텍스트 
        dialogueText.text = dialogueDatas[curDialogueIdx].dialogue; // 다이얼로그 배열에 저장된 대사 텍스트

        // character.ChangeSprite(dialogueDatas[curDialogueIdx].characterSprite);
        curDialogueIdx++;

        // StartCoroutine(Typing([curDialogueIdx]));
    }

    IEnumerator NarrationTyping(string narration)
    {
        // 텍스트 박스 초기화
        narrationText.text = null;

        // 글자 길이만큼 반복
        for (int i = 0; i < narration.Length; i++)
        {
            narrationText.text += narration[i];

            // 속도 딜레이
            yield return new WaitForSeconds(0.05f);
        }

        // 속도 딜레이
        yield return new WaitForSeconds(1.5f);
        NextNarration();
    }

    IEnumerator DialogueTyping(string dialogue)
    {
        // 텍스트 박스 초기화
        dialogueText.text = null;

        // 글자 길이만큼 반복
        for (int i = 0; i < dialogue.Length; i++)
        {
            dialogueText.text += dialogue[i];
            // BGM[1].Play();

            // 속도 딜레이
            yield return new WaitForSeconds(0.05f);
        }

        // 속도 딜레이
        yield return new WaitForSeconds(1.5f);
        NextDialogue();
    }
}

[System.Serializable]
public class DialogueData
{
    public Sprite charaterSprite;   // 캐릭터 이미지   
    public string name; // 이름   
    public string dialogue; // 대화 내용
}

[System.Serializable]
public class NarrationData
{
    public string narration;    // 나레이션
}