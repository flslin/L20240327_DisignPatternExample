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
        // onValueChaged.AddListener()�� �����̴��� onValueChanged�� ����� �߰��ϴ� �Լ�
        // delegate�� �̿��� �ѱ�� ���� ����
        // ��ư�� onClick�� AddListener ����� ����
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
