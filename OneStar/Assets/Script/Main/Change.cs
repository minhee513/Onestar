using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Change : MonoBehaviour
{
    // public TMP_Text startBtn;
    // Color newColor;
    // string newColor_code;

    public Button startBtn; // ���� ��ư
    public GameObject inputPanel;   // ��ǲ�ʵ� �г�
    public InputField playerName;   // ��ǲ�ʵ忡�� ������ �÷��̾� �̸�

    // private string player = "�̿�ȯ";

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

    /*
    public void ChangeBtnColor()
    {
        newColor_code = "#F9FF00";
        if (ColorUtility.TryParseHtmlString(newColor_code, out newColor))
        {
            startBtn.color = newColor;
        }
    }
    */
}
