using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
    public GameObject setPanel; // ���� �г�
    public Button setBtn;   // ���� ��ư
    public Button setoverBtn;   // ���� �г� ������ ��ư

    void Start()
    {
        setPanel.SetActive(false);  // �� ���� �� ���� �г� ��Ȱ��ȭ
    }

    void Update()
    {
        
    }

    // ���� ��ư ������ ��
    public void setTrue()
    {
        setPanel.SetActive(true);   // ���� �г� Ȱ��ȭ
    }

    // ���� �гο��� '������' ������ ��
    public void setFalse()
    {
        setPanel.SetActive(false);  // ���� �г� ��Ȱ��ȭ
    }
}
