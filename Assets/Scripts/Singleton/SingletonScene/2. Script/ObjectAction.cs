using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // �浹 �� ����� �ҽ� ������Ʈ�� ������ �÷��̸� �����ϰ� ��ü�� �ı�
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("��");
        Destroy(gameObject);
    }


}
