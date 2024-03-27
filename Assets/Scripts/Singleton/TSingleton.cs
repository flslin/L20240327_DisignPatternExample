using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 제네릭 클래스
// 클래스명<T>로 구성하면 T자리에 타입을 넣을수 있음

// 제네릭 제약 조건
//where T : struct => T는 null을 허용하지 않는 값의 형식
//where T : class => T는 참조(Reference) 형식
//where T : new() => 기본 생성자가 있어야함. 다른 제약조건과 같이 쓰일 경우 가장 마지막에 작성됨
//where T : notNull => T는 null이 아닌 형식, 제역조건 위반 시 에러가 아닌 경고만 뜸
//where T : (base)className => T는 지정된 기본 클래스이거나 이 클래스에서 파생된 클래스여야 함.
//where T : interfaceName => T는 지정된 기본 인터페이스거나 이 인터페이스에서 파생된 유형

// 타입 파라미터가 2개 이상일 경우 제약 조건을 각각 작성하는 것이 가능
//public class MultiType<T, K> where T : struct where K : class { }

public class TSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public int value;

    // T 자리에는 해당 클래스를 상속받는 클래스타입을 넣을 수 있음
    // 이때 이 클래스는 MonoBehaviour 또는MonoBehaviour를 상속받은 클래스
    private static T _instance;
    private static bool _shutDown;
    private static object _lock = new object();

    // 프로퍼티는 주로 변수가 소문자로 구현될 때 앞글자만 대문자로 쓰는 경우가 많음
    public static T Instance
    {
        get
        {
            // 게임 종료 시 오브젝트보다 싱글톤의 onDestroy가 먼저 실행 될 수 있는 상황 방지
            if (_shutDown)
            {
                return null;
            }

            // C#의 lock 기능. 특정 블럭의 코드를 한번에 하나의 쓰레드만 실행 할 수 있도록 처리하는 도구
            // 프로그램에서 공유 자원으로 사용되는 값들에 주로 사용되는 키워드
            lock(_lock)
            {
                if (_instance == null)
                {
                    // 인스턴스가 현재 존재하는지 체크
                    _instance = FindObjectOfType<T>();

                    // 조사를 했는데도 생성되지 않았을 경우
                    if (_instance != null)
                    {
                        var sObj = new GameObject();
                        // T를 컴포넌트로 추가한 sObj로 할당
                        _instance = sObj.AddComponent<T>();
                        sObj.name = typeof(T).Name + "Singleton";

                        DontDestroyOnLoad(sObj);
                    }
                }
                return _instance;
            }

            if (_instance == null)
            {
                // 인스턴스가 존재하는지 체크
                _instance = FindObjectOfType<T>();
            }
            return _instance;
        }
    }

    private void OnApplicationQuit()
    {
        _shutDown = true;
    }

    private void OnDestroy()
    {
        _shutDown = false;
    }
}
