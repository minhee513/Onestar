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

    public Button startBtn; // 시작 버튼
    public GameObject inputPanel;   // 인풋필드 패널
    public InputField playerName;   // 인풋필드에서 저장할 플레이어 이름

    // private string player = "이용환";

    private void Start()
    {
        inputPanel.SetActive(false); // 씬 시작 시 인풋필드 패널 비활성화
    }

    // 시작 버튼 클릭 시 인풋필드 패널이 활성화되도록
    public void inputName()
    {
        inputPanel.SetActive(true);
    }

    // 플레이어 이름 입력 시 씬 변경
    public void playerLogin()
    {
        if(playerName.text != null) // null 값이 아닐 때
        {
            SceneChange();
        }
    }

    // 프롤로그로 씬 변경
    public void SceneChange()
    {
        StartCoroutine(LoadScene());    
    }

    IEnumerator LoadScene() 
    {
        yield return new WaitForSeconds(0.3f); // 씬 변경 전 0.3f 딜레이
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
