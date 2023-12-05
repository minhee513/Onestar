using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio;
    }

    // Inspector�� ǥ���� ��� ���� ���
    public BgmType[] BGMList;

    private AudioSource BGM;
    private string NowBGMname = "";

    void Start()
    {
        BGM = gameObject.AddComponent<AudioSource>();
        BGM.loop = true;
        if (BGMList.Length > 0) PlayBGM(BGMList[0].name);
    }

    public void PlayBGM(string name)
    {
        if (NowBGMname.Equals(name)) return;

        for (int i = 0; i < BGMList.Length; ++i)
            if (BGMList[i].name.Equals(name))
            {
                BGM.clip = BGMList[i].audio;
                BGM.Play();
                NowBGMname = name;
            }
    }
}

/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VillageEnter : MonoBehaviour
{
    // Inspector ������ ǥ���� ������� �̸�
    public string bgmName = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("myplayer"))
        {
            // �÷��̾ Ʈ���ſ� ������ ��, ��������� �����ϴ� �ڵ�
            PlayMusicOperator musicOperator = FindObjectOfType<PlayMusicOperator>();
            if (musicOperator != null)
            {
                musicOperator.PlayBGM(bgmName);
            }
        }
    }

    private void Start()
    {
        // ���� �ε�� ���� �̺�Ʈ�� OnSceneLoaded �޼��带 ���
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ���� �ε�� ���� �̺�Ʈ���� ��������� �����ϴ� �ڵ�
        PlayMusicOperator musicOperator = FindObjectOfType<PlayMusicOperator>();
        if (musicOperator != null)
        {
            musicOperator.PlayBGM(bgmName);
        }
    }

    private void OnDestroy()
    {
        // �� ��ü �ı� �ÿ� ��ϵ� �̺�Ʈ ����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
 */