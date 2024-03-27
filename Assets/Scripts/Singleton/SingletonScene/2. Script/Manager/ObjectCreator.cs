using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        // 마우스 왼쪽 버튼을 누르면 정해진 좌표에 프리팹 생성
        if(Input.GetMouseButton(0))
        {
            Vector3 pos = new Vector3(0.0f, 3.0f, 0.0f);
            Instantiate(sphere, pos , Quaternion.identity);
        }
    }
}
