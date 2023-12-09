using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    public TextMeshProUGUI resultText; // TextMeshProUGUI ������Ʈ�� ������ ����

    private void Start()
    {
        resultText = GetComponentInChildren<TextMeshProUGUI>(); // TextMeshProUGUI ������Ʈ�� ã�Ƽ� resultText ������ �����մϴ�

        int correctCount = PlayerPrefs.GetInt("correctCount"); // "correctCount" Ű�� ����� ���� ��������, ���� ���� ��� �⺻������ 0�� ����մϴ�.
        resultText.text = correctCount + "�� ������ϴ�.";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Day5");
        }
    }
}
