using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ���� : ���丮(Factory) -> ��ü�� �����ϴ� Ŭ����

// ���� ���丮 : �־��� �Է��� ������� �ٸ� ������ ��ü�� ��ȯ�ϴ� �޼ҵ尡 ����

// ���� ���丮 ����

// 1. ���ֿ� ���� ������ enum���� �ۼ�
public enum UnitType
{
    Vulture, SiegeTank, Goliath
}

public class UnitFactory
{
    // 2. ������ �����ϴ� �޼ҵ带 ���� �޼ҵ�� ����
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
