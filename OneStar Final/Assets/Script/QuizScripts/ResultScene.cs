using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    public TextMeshProUGUI resultText; // TextMeshProUGUI 컴포넌트를 참조할 변수

    private void Start()
    {
        resultText = GetComponentInChildren<TextMeshProUGUI>(); // TextMeshProUGUI 컴포넌트를 찾아서 resultText 변수에 연결합니다

        int correctCount = PlayerPrefs.GetInt("correctCount"); // "correctCount" 키로 저장된 값을 가져오되, 값이 없을 경우 기본값으로 0을 사용합니다.
        resultText.text = correctCount + "개 맞췄습니다.";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Day5");
        }
    }
}
