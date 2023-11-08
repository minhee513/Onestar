using System.Collections;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public DialogueData[] dialogueDatas;    // ��� ���� ����

    public TMP_Text nameText;   // �̸�
    public TMP_Text dialogueText;   // ���

    public Character character; // ĳ����

    private void Start()
    {
        character = FindObjectOfType<Character>();

        nameText.text = ""; // �̸� �ؽ�Ʈ 
        dialogueText.text = ""; // ��ȭ �ؽ�Ʈ
    }

    int curDialogueIdx = 0; // ��ȭ ���� üũ

    private void Update()
    {

        // ���콺 Ŭ�� üũ
        if (Input.GetMouseButtonDown(0))
        {
            NextDialogue();
        }
    }

    public void NextDialogue()
    {
        if (dialogueDatas.Length <= curDialogueIdx)
        {
            // ��ȭ ����
            return;
        }

        nameText.text = dialogueDatas[curDialogueIdx].name; // ���̾�α� �迭�� ����� �̸� �ؽ�Ʈ 
        dialogueText.text = dialogueDatas[curDialogueIdx].dialogue; // ���̾�α� �迭�� ����� ��� �ؽ�Ʈ

        // character.ChangeSprite(dialogueDatas[curDialogueIdx].characterSprite);
        curDialogueIdx++;

        // StartCoroutine(Typing([curDialogueIdx]));
    }

    IEnumerator Typing(string trailer)
    {
        // �ؽ�Ʈ �ڽ� �ʱ�ȭ
        dialogueText.text = null;

        // ���� ���̸�ŭ �ݺ�
        for (int i = 0; i < trailer.Length; i++)
        {
            dialogueText.text += trailer[i];
            // BGM[1].Play();

            // �ӵ� ������
            yield return new WaitForSeconds(0.05f);
        }

        // �ӵ� ������
        yield return new WaitForSeconds(1.5f);
        NextDialogue();
    }
}

[System.Serializable]
public class DialogueData
{
    public Sprite charaterSprite;   // ĳ���� �̹���   
    public string name; // �̸�   
    public string dialogue; // ��ȭ ����
}