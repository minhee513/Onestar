using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public DialogueData[] dialogueDatas;    // 대사 저장 변수

    public TMP_Text nameText;   // 이름
    public TMP_Text dialogueText;   // 대사

    public Character character; // 캐릭터

    private void Start()
    {
        character = FindObjectOfType<Character>();

        nameText.text = ""; // 이름 텍스트 
        dialogueText.text = ""; // 대화 텍스트
    }

    int curDialogueIdx = 0; // 대화 개수 체크

    private void Update()
    {

        // 마우스 클릭 체크
        if (Input.GetMouseButtonDown(0))
        {
            NextDialogue();
        }
    }

    public void NextDialogue()
    {
        if (dialogueDatas.Length <= curDialogueIdx)
        {
            // 대화 없음
            return;
        }

        nameText.text = dialogueDatas[curDialogueIdx].name; // 다이얼로그 배열에 저장된 이름 텍스트 
        dialogueText.text = dialogueDatas[curDialogueIdx].dialogue; // 다이얼로그 배열에 저장된 대사 텍스트

        // character.ChangeSprite(dialogueDatas[curDialogueIdx].characterSprite);
        curDialogueIdx++;

        // StartCoroutine(Typing([curDialogueIdx]));
    }

    IEnumerator Typing(string trailer)
    {
        // 텍스트 박스 초기화
        dialogueText.text = null;

        // 글자 길이만큼 반복
        for (int i = 0; i < trailer.Length; i++)
        {
            dialogueText.text += trailer[i];
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