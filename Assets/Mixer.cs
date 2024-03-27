using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    public AudioMixer MyMixer;
    public Slider Slider;

    private void Awake()
    {
        // onValueChaged.AddListener()는 슬라이더의 onValueChanged에 기능을 추가하는 함수
        // delegate를 이용해 넘기는 것이 가능
        // 버튼의 onClick도 AddListener 기능이 있음
        Slider.onValueChanged.AddListener(delegate { AudioControll(); });
    }

    public void AudioControll()
    {
        float sound = Slider.value;

        if (sound == -40f)
            MyMixer.SetFloat("BGM", -80);
        else
            MyMixer.SetFloat("BGM", sound);
    }

    public void ToggleAudio()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }

}
