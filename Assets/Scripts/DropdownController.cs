using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
    public Dropdown options;

    List<Dropdown.OptionData> optionsData;

    public void Start()
    {
        optionsData = options.options;

        optionsData.Clear(); // ������ ����

        for (int i = 0; i < 5; i++)
        {
            optionsData.Add(new Dropdown.OptionData(i.ToString()));
        }

        options.onValueChanged.AddListener(Check);
    }

    public void Check(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("���� �޴� ��õ��");
                break;
            case 1:
                Debug.Log("���� �����ϼ˽���");
                break;
            case 2:
                Debug.Log("�� �ȳ��Ҵ��");
                break;
            case 3:
                Debug.Log("��");
                break;
            case 4:
                Debug.Log("����");
                break;
            default:
                break;
        }
    }
}
