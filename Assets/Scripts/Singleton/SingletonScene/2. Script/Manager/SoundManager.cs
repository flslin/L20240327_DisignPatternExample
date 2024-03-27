using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider BGMSlider;
    public Slider SkillSoundSlider;
    public Slider Slider;
    public Button MuteButton;
    public AudioSource BGM;
    public AudioSource Skill;
    
    private static SoundManager instance = null;

    public static SoundManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SoundManager();
            }
            return instance;
        }
    }

    private void Start()
    {
        if (instance != null)
        {
            instance = this;
        }

    }

    public void Volume()
    {
        BGMSlider = GetComponent<Slider>();
        SkillSoundSlider = GetComponent<Slider>();
        Slider = GetComponent<Slider>();

        BGM = GetComponent<AudioSource>();
        Skill = GetComponent<AudioSource>();

        BGM.volume = BGMSlider.value;
        Skill.volume = SkillSoundSlider.value;
    }

    public void Mute()
    {
        BGMSlider.value = 0;
        SkillSoundSlider.value = 0;
        Slider.value = 0;

        BGM.volume = 0;
        Skill.volume = 0;

        
    }
}
