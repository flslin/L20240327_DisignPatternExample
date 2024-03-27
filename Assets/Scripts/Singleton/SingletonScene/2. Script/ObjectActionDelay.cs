using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAcionDelay : MonoBehaviour
{
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();    
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_AudioSource.Play();
        Destroy(gameObject, m_AudioSource.clip.length);
        // 파괴에 클립의 길이만큼 딜레이(대기시간) 추가
    }

    // 사운드가 나지않는 문제는 해결, 하지만 부자연스러움
}
