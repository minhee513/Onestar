using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TrailerDialogue : MonoBehaviour
{
    public TMP_Text TrailerText;    // ������ Ʈ���Ϸ� �ؽ�Ʈ

    // string dialogue;

    public string[] T_Dialogue; // Ʈ���Ϸ� ��� ���� �迭
    public string[] dialogues;  // StartTalk �Լ����� �Ű����� �����ϴ� �迭

    int curDialogueIdx = 0; // ���� ��� ����� ���� ����
    AudioSource[] BGM;

    // public Image image;

    // public GameObject Fadein;

    void Awake()
    {
        BGM = GetComponents<AudioSource>(); // BGM ������Ʈ ����
        // Fadein.GetComponent<Trailer_FadeIn>().FadeButton();
    }

    void Start()
    {
        StartTalk(T_Dialogue);
    }

    void Update()
    {
        
    }

    public void StartTalk(string[] trailers)
    {
        dialogues = trailers;

        // curDialogueIdx��° ��� ���
        StartCoroutine(Typing(dialogues[curDialogueIdx]));
    }

    public void NextTrailer()
    {
        TrailerText.text = null;    // �ؽ�Ʈ �ڽ� �ʱ�ȭ
        curDialogueIdx++;   // ���� �迭 ����� ���� +1

        // curDialogueIdx�� �迭�� ���̿� ������ ����
        if (curDialogueIdx == dialogues.Length)
        {
            EndTalk();
            return;
        }

        StartCoroutine(Typing(dialogues[curDialogueIdx]));
    }

    public void EndTalk()
    {
        // curDialogueIdx �ʱ�ȭ
        curDialogueIdx = 0;
        Debug.Log("Ʈ���Ϸ� ��");

        // curDialogueIdx�� 0�̸� �� ����
        if (curDialogueIdx == 0)
        {
            SceneManager.LoadScene(1);
            // Fadein.SetActive(true);
        }
    }

    IEnumerator Typing(string trailer)
    {
        TrailerText.text = null;    // �ؽ�Ʈ �ڽ� �ʱ�ȭ

        // ���� ���̸�ŭ �ݺ�
        for (int i = 0; i < trailer.Length; i++)
        {
            TrailerText.text += trailer[i];
            BGM[1].Play();  // �ؽ�Ʈ Ÿ���� ȿ���� ���

            // �ӵ�
            yield return new WaitForSeconds(0.05f); // Ÿ���� ������ �ð�, ���ϴ� �ð����� ���� ����
        }

        // ���� ��� ������
        yield return new WaitForSeconds(1.5f);
        NextTrailer();
    }
}

[System.Serializable]
public class TrailerData
{
    public string Trailer;
}
