using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        // ���콺 ���� ��ư�� ������ ������ ��ǥ�� ������ ����
        if(Input.GetMouseButton(0))
        {
            Vector3 pos = new Vector3(0.0f, 3.0f, 0.0f);
            Instantiate(sphere, pos , Quaternion.identity);
        }
    }
}
