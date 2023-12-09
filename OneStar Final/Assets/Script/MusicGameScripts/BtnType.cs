using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public Transform buttonScale;

    public GameObject PlayBtn;
    public GameObject OptionBtn;
    public GameObject SongBtn;
    public GameObject SoundBtn;
    public GameObject BackBtn1;
    public GameObject BackBtn2;

    public void Play()
    {
        PlayBtn.SetActive(false);
        OptionBtn.SetActive(false);
        SongBtn.SetActive(true);
    }
    public void Option()
    {
        PlayBtn.SetActive(false);
        OptionBtn.SetActive(false);
        SoundBtn.SetActive(true);
    }
    public void Back1()
    {
        PlayBtn.SetActive(true);
        OptionBtn.SetActive(true);
        SongBtn.SetActive(false);
    }
    public void Back2()
    {
        PlayBtn.SetActive(true);
        OptionBtn.SetActive(true);
        SoundBtn.SetActive(false);
    }
}
