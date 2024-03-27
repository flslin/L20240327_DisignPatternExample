using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 디자인 패턴 : 팩토리(Factory) -> 객체를 생성하는 클래스

// 심플 팩토리 : 주어진 입력을 기반으로 다른 유형의 객체를 반환하는 메소드가 존재

// 심플 팩토리 구현

// 1. 유닛에 대한 유형을 enum으로 작성
public enum UnitType
{
    Vulture, SiegeTank, Goliath
}

public class UnitFactory
{
    // 2. 유닛을 생성하는 메소드를 정적 메소드로 구현
    public static Unit CreateUnit(UnitType type)
    {
        Unit unit = null;

        switch (type)
        {
            case UnitType.Vulture:
                unit = new Vulture();
                break;
            case UnitType.SiegeTank:
                unit = new SiegeTank();
                break;
            case UnitType.Goliath:
                unit = new Goliath();
                break;
        }
        return unit;
    }
}
