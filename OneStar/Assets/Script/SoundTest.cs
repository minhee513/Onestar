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

    // Inspector에 표시할 배경 음악 목록
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
    // Inspector 영역에 표시할 배경음악 이름
    public string bgmName = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("myplayer"))
        {
            // 플레이어가 트리거에 들어왔을 때, 배경음악을 변경하는 코드
            PlayMusicOperator musicOperator = FindObjectOfType<PlayMusicOperator>();
            if (musicOperator != null)
            {
                musicOperator.PlayBGM(bgmName);
            }
        }
    }

    private void Start()
    {
        // 씬이 로드될 때의 이벤트에 OnSceneLoaded 메서드를 등록
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬이 로드될 때의 이벤트에서 배경음악을 변경하는 코드
        PlayMusicOperator musicOperator = FindObjectOfType<PlayMusicOperator>();
        if (musicOperator != null)
        {
            musicOperator.PlayBGM(bgmName);
        }
    }

    private void OnDestroy()
    {
        // 이 객체 파괴 시에 등록된 이벤트 해제
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
 */