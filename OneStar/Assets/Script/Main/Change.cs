using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Change : MonoBehaviour
{
    public Button startBtn; // ���� ��ư
    public GameObject inputPanel;   // ��ǲ�ʵ� �г�
    public InputField playerName;   // ��ǲ�ʵ忡�� ������ �÷��̾� �̸�

    private void Start()
    {
        inputPanel.SetActive(false); // �� ���� �� ��ǲ�ʵ� �г� ��Ȱ��ȭ
    }

    // ���� ��ư Ŭ�� �� ��ǲ�ʵ� �г��� Ȱ��ȭ�ǵ���
    public void inputName()
    {
        inputPanel.SetActive(true);
    }

    // �÷��̾� �̸� �Է� �� �� ����
    public void playerLogin()
    {
        if(playerName.text != null) // null ���� �ƴ� ��
        {
            SceneChange();
        }
    }

    // ���ѷα׷� �� ����
    public void SceneChange()
    {
        StartCoroutine(LoadScene());    
    }

    IEnumerator LoadScene() 
    {
        yield return new WaitForSeconds(0.3f); // �� ���� �� 0.3f ������
        SceneManager.LoadScene(1);
    }
}
