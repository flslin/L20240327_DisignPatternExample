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
        // �ı��� Ŭ���� ���̸�ŭ ������(���ð�) �߰�
    }

    // ���尡 �����ʴ� ������ �ذ�, ������ ���ڿ�������
}
