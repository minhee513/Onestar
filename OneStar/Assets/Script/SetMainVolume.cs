using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetMainVolume : MonoBehaviour
{
    public AudioMixer mainMixer;    // ���� ������ ���� Main Scene ����� �ͼ� ����

    // ����� ���� ����
    public void Setlevel(float sliderValue)
    {
        mainMixer.SetFloat("MainVol", Mathf.Log10(sliderValue) * 20);
    }
}
