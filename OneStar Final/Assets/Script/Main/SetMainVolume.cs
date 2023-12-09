using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetMainVolume : MonoBehaviour
{
    public AudioMixer mainMixer;    // 볼륨 조절을 위한 Main Scene 오디오 믹서 변수

    // 오디오 레벨 설정
    public void Setlevel(float sliderValue)
    {
        mainMixer.SetFloat("MainVol", Mathf.Log10(sliderValue) * 20);
    }
}
