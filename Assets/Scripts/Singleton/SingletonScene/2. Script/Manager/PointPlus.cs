using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            // 싱글톤 클래스.Instance.메소드명을 통해 기능 사용
            int result = ADManger.Instance.GetPoint();

            Debug.Log($"현재 포인트 : {result}");
        }
    }
}
