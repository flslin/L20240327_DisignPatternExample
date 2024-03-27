using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ش� �̱����� �ش� ����� ���� �̵��ص� �����Ǳ⸦ �ٶ� �� �����ϴ� �ڵ�
public class MonoSingleton : MonoBehaviour
{
    private static MonoSingleton instance;

    public static MonoSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                // 1. ���ӳ��� MonoSingleton ������ ������Ʈ�� �����ϴ� �� Ȯ��
                var obj = FindObjectOfType<MonoSingleton>();
                // ������Ʈ�� �����Ѵٸ� �ν��Ͻ��� �ش� ������ ó��
                if (obj != null)
                {
                    instance = obj;
                }
                else
                {
                    // ���� ������Ʈ�� "MonoSingleton" �̸����� �����ϰ� ������Ʈ �߰�.
                    var newObject = new GameObject("MonoSingleton").AddComponent<MonoSingleton>();
                }
            }
            return instance;
        }
    }

    public void Awake()
    {
        // MonoSingleton ������ ������Ʈ���� ���ӿ��� ����
        var obj = FindObjectsOfType<MonoSingleton>();

        // ������Ʈ �迭�� ���̰� 1�� �ƴ϶�� (��ü�� �Ѱ��� �ƴ϶��)
        if(obj.Length != 1)
        {
            Destroy(gameObject);
            return;
        }
        // �ش� �ڵ� �ۼ� �� ���� �̵��ص� ������.
        DontDestroyOnLoad(gameObject);
    }
}
