using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
    public GameObject setPanel; // 설정 패널
    public Button setBtn;   // 설정 버튼
    public Button setoverBtn;   // 설정 패널 나가기 버튼

    void Start()
    {
        setPanel.SetActive(false);  // 씬 시작 시 설정 패널 비활성화
    }

    void Update()
    {
        
    }

    // 설정 버튼 눌렀을 때
    public void setTrue()
    {
        setPanel.SetActive(true);   // 설정 패널 활성화
    }

    // 설정 패널에서 '나가기' 눌렀을 때
    public void setFalse()
    {
        setPanel.SetActive(false);  // 설정 패널 비활성화
    }
}
