using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADManger : MonoBehaviour
{
    private static ADManger instance = null;

    public static ADManger Instance
    {
        get 
        {
            if (instance == null)
            {
                instance = new ADManger();
            }
            return instance; 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if(instance ==null)
        {
            instance = this;
        }
    }

    int point = 0;

    public void Play(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public int GetPoint() => point++;
}
