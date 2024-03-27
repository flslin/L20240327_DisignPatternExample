using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���׸� Ŭ����
// Ŭ������<T>�� �����ϸ� T�ڸ��� Ÿ���� ������ ����

// ���׸� ���� ����
//where T : struct => T�� null�� ������� �ʴ� ���� ����
//where T : class => T�� ����(Reference) ����
//where T : new() => �⺻ �����ڰ� �־����. �ٸ� �������ǰ� ���� ���� ��� ���� �������� �ۼ���
//where T : notNull => T�� null�� �ƴ� ����, �������� ���� �� ������ �ƴ� ��� ��
//where T : (base)className => T�� ������ �⺻ Ŭ�����̰ų� �� Ŭ�������� �Ļ��� Ŭ�������� ��.
//where T : interfaceName => T�� ������ �⺻ �������̽��ų� �� �������̽����� �Ļ��� ����

// Ÿ�� �Ķ���Ͱ� 2�� �̻��� ��� ���� ������ ���� �ۼ��ϴ� ���� ����
//public class MultiType<T, K> where T : struct where K : class { }

public class TSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public int value;

    // T �ڸ����� �ش� Ŭ������ ��ӹ޴� Ŭ����Ÿ���� ���� �� ����
    // �̶� �� Ŭ������ MonoBehaviour �Ǵ�MonoBehaviour�� ��ӹ��� Ŭ����
    private static T _instance;
    private static bool _shutDown;
    private static object _lock = new object();

    // ������Ƽ�� �ַ� ������ �ҹ��ڷ� ������ �� �ձ��ڸ� �빮�ڷ� ���� ��찡 ����
    public static T Instance
    {
        get
        {
            // ���� ���� �� ������Ʈ���� �̱����� onDestroy�� ���� ���� �� �� �ִ� ��Ȳ ����
            if (_shutDown)
            {
                return null;
            }

            // C#�� lock ���. Ư�� ���� �ڵ带 �ѹ��� �ϳ��� �����常 ���� �� �� �ֵ��� ó���ϴ� ����
            // ���α׷����� ���� �ڿ����� ���Ǵ� ���鿡 �ַ� ���Ǵ� Ű����
            lock(_lock)
            {
                if (_instance == null)
                {
                    // �ν��Ͻ��� ���� �����ϴ��� üũ
                    _instance = FindObjectOfType<T>();

                    // ���縦 �ߴµ��� �������� �ʾ��� ���
                    if (_instance != null)
                    {
                        var sObj = new GameObject();
                        // T�� ������Ʈ�� �߰��� sObj�� �Ҵ�
                        _instance = sObj.AddComponent<T>();
                        sObj.name = typeof(T).Name + "Singleton";

                        DontDestroyOnLoad(sObj);
                    }
                }
                return _instance;
            }

            if (_instance == null)
            {
                // �ν��Ͻ��� �����ϴ��� üũ
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
