using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // 충돌 시 오디오 소스 컴포넌트를 가져와 플레이를 진행하고 물체를 파괴
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("펑");
        Destroy(gameObject);
    }


}
