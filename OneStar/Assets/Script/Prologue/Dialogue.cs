using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public DialogueData[] dialogueDatas;    // ��� ���� ����
    public NarrationData[] narrationDatas;  // �����̼� ���� ����

    public GameObject nPanel;
    public GameObject dPanel;   // Dialogue �г�
    public GameObject appear;   // Dialogue �г� ��ư
    public GameObject gPanel;   // ���� ȭ�� �г�

    public TMP_Text nameText;   // �̸�
    public TMP_Text dialogueText;   // ���

    public TMP_Text narrationText;  // �����̼�


    private void Start()
    {
        nameText.text = ""; // �̸� �ؽ�Ʈ 
        dialogueText.text = ""; // ��ȭ �ؽ�Ʈ

        narrationText.text = "";

        nPanel.SetActive(false);
        appear.SetActive(false);
        dPanel.SetActive(false);
        gPanel.SetActive(false);
    }

    int curDialogueIdx = 0; // ��ȭ ���� üũ
    int curNarrationIdx = 0; // �����̼� ���� üũ

    private void Update()
    {

        // ���콺 Ŭ�� üũ
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
            // ��ȭ ����
            appear.SetActive(true);
            return;
        }

        narrationText.text = narrationDatas[curNarrationIdx].narration; // �����̼� �迭�� ����� �ؽ�Ʈ
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

        nameText.text = dialogueDatas[curDialogueIdx].name; // ���̾�α� �迭�� ����� �̸� �ؽ�Ʈ 
        dialogueText.text = dialogueDatas[curDialogueIdx].dialogue; // ���̾�α� �迭�� ����� ��� �ؽ�Ʈ

        // character.ChangeSprite(dialogueDatas[curDialogueIdx].characterSprite);
        curDialogueIdx++;

        // StartCoroutine(Typing([curDialogueIdx]));
    }

    IEnumerator NarrationTyping(string narration)
    {
        // �ؽ�Ʈ �ڽ� �ʱ�ȭ
        narrationText.text = null;

        // ���� ���̸�ŭ �ݺ�
        for (int i = 0; i < narration.Length; i++)
        {
            narrationText.text += narration[i];

            // �ӵ� ������
            yield return new WaitForSeconds(0.05f);
        }

        // �ӵ� ������
        yield return new WaitForSeconds(1.5f);
        NextNarration();
    }

    IEnumerator DialogueTyping(string dialogue)
    {
        // �ؽ�Ʈ �ڽ� �ʱ�ȭ
        dialogueText.text = null;

        // ���� ���̸�ŭ �ݺ�
        for (int i = 0; i < dialogue.Length; i++)
        {
            dialogueText.text += dialogue[i];
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

[System.Serializable]
public class NarrationData
{
    public string narration;    // �����̼�
}