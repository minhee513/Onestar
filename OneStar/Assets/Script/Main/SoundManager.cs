using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;

    public AudioSource bgm;
    public AudioClip[] bgmList;

    private void Awake()
    {
        var soundManagers = FindObjectsOfType<SoundManager>();
        if (soundManagers.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }

        /*
        if(instance == null)
        {
            instance = this;
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        */
    }

    private void OnSceneLoaded()
    {
        GameObject trailerPanel = GameObject.FindGameObjectWithTag("TrailerPanel");

        if (trailerPanel != null)
        {
            // bgmList[1].Play();
        }
    }
    
    /*
    public void BGMSoundPlay(AudioClip clip)
    {
        bgm.clip = clip;
        bgm.loop = true;
        bgm.Play();
    }
    */

    void Start()
    {
        bgm.Play();
    }

    void Update()
    {
        
    }
}
