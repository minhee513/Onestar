using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // '������' ��ư ������ ���ø����̼� ����
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Exit Click");
    }
}
