using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // '나가기' 버튼 누르면 애플리케이션 종료
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Exit Click");
    }
}
