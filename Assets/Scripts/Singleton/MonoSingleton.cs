using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 해당 싱글톤은 해당 기능이 씬을 이동해도 유지되기를 바랄 때 설계하는 코드
public class MonoSingleton : MonoBehaviour
{
    private static MonoSingleton instance;

    public static MonoSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                // 1. 게임내에 MonoSingleton 형태의 오브젝트가 존재하는 지 확인
                var obj = FindObjectOfType<MonoSingleton>();
                // 오브젝트가 존재한다면 인스턴스를 해당 값으로 처리
                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    // 게임 오브젝트를 "MonoSingleton" 이름으로 생성하고 컴포넌트 추가.
                    var newObject = new GameObject("MonoSingleton").AddComponent<MonoSingleton>();
                }
            }
            return instance;
        }
    }

    public void Awake()
    {
        // MonoSingleton 형태의 오브젝트들을 게임에서 조사
        var obj = FindObjectsOfType<MonoSingleton>();

        // 오브젝트 배열의 길이가 1이 아니라면 (객체가 한개가 아니라면)
        if(obj.Length != 1)
        {
            Destroy(gameObject);
            return;
        }
        // 해당 코드 작성 시 씬을 이동해도 유지됨.
        DontDestroyOnLoad(gameObject);
    }
}
