using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̱��� ���� (Singleton Pattern)
// Ŭ������ ��ü�� �ϳ��� �����ϵ��� �����ϴ� ����
// �� �ϳ��� ��ü�� ������ ��𼭵� ����� ������ ����
// ����Ƽ������ �ַ� XXController, XXXManager ���� ������ �ش� ������ ���� ���

// �̱��� ������ static Ű���带 Ȱ���� ������� ���� ������ ����ϰ� �Ǵ� ����.
// ���� ���� ������ ������ �޸� ���� / ��Ƽ �½�ŷ ȯ�濡���� ����, �ڵ� �����丵(����)
// �������� �ش� ���� ���� ��� �ߴ� �� ��� ��� ���� ���� ������ �״�� ������ ��.

// �̱��� ��� �� ������ ��Ȳ �Ǵ�
// ���뼺�� ���� Ư�� Ŭ�������� ����ϴ� �ڵ��� ��� �̱������� �������� �ʰ� �� Ŭ������ �ڵ带 �ִ°� �� �̵���.
// ����Ƽ���� �����Ǵ� ����� �ִٸ� �� ������� �ذ��ϴ� ���� ���� �� ����

// ���� - �ٸ� Ŭ������ ���������� ������
//        ��ü ���ٿ� �ſ� ������(����)
//        ���ʿ��� �ߺ� ���踦 ���� �� ����. �޸��� ���� ���� ȿ��

public class SingletonBasic : MonoBehaviour
{
    // ���� ���
    // 1. �ܺο��� ������ �� ������, ���� ������ Ŭ���� ��ü�� ������ ����
    private static SingletonBasic instance = null;

    // 2. �����ڸ� ���� �����ϴ� ���� �Ұ���
    private SingletonBasic() { }

    // 3. �޼ҵ峪 ������Ƽ�� ���� ������ �����ϵ��� ����,
    //    ��ü�� ���� ��� ��ü�� �����ϰ� �Ϲ����� ��쿡�� ������� ��ü�� return �ϵ��� ����
    // ������ ������Ƽ�� ���� ���ϰ� ������
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
