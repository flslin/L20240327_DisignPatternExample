using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 싱글톤 패턴 (Singleton Pattern)
// 클래스의 객체를 하나만 생성하도록 설계하는 패턴
// 그 하나의 객체를 참조해 어디서든 사용이 가능한 패턴
// 유니티에서는 주로 XXController, XXXManager 등의 구현에 해당 패턴을 자주 사용

// 싱글톤 패턴은 static 키워드를 활용한 기능으로 전역 변수를 사용하게 되는 개념.
// 따라서 전역 변수의 문제인 메모리 부족 / 멀티 태스킹 환경에서의 오류, 코드 리팩토링(수정)
// 과정에서 해당 전역 변수 사용 중단 시 모든 모듈 수정 등의 단점을 그대로 가지게 됨.

// 싱글톤 사용 시 적절한 상황 판단
// 범용성이 적어 특정 클래스에만 사용하는 코드일 경우 싱글톤으로 구현하지 않고 그 클래스에 코드를 넣는게 더 이득임.
// 유니티에서 제공되는 기능이 있다면 그 기능으로 해결하는 것이 나을 수 있음

// 장점 - 다른 클래스와 독립적으로 유지됨
//        객체 접근에 매우 용이함(전역)
//        불필요한 중복 설계를 피할 수 있음. 메모리의 낭비를 막는 효과

public class SingletonBasic : MonoBehaviour
{
    // 구현 방법
    // 1. 외부에서 접근할 수 없으며, 정적 형태의 클래스 객체를 가지고 있음
    private static SingletonBasic instance = null;

    // 2. 생성자를 통해 생성하는 것이 불가능
    private SingletonBasic() { }

    // 3. 메소드나 프로퍼티를 통해 접근이 가능하도록 설계,
    //    객체가 없는 경우 객체를 생성하고 일반적인 경우에는 만들어진 객체를 return 하도록 설계
    // 보통은 프로퍼티를 통해 편하게 설계함
    public static SingletonBasic Instance
    {
        get
        {
            if (instance == null)
                instance = new SingletonBasic();
            return instance;
        }
    }

    public static SingletonBasic GetInstance()
    {
        if (instance == null)
            instance = new SingletonBasic();
        return instance;
    }

}
