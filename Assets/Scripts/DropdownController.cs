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

        optionsData.Clear(); // 데이터 삭제

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
                Debug.Log("저녁 메뉴 추천좀");
                break;
            case 1:
                Debug.Log("오늘 수고하셧슴다");
                break;
            case 2:
                Debug.Log("얼마 안남았대요");
                break;
            case 3:
                Debug.Log("광");
                break;
            case 4:
                Debug.Log("이히");
                break;
            default:
                break;
        }
    }
}
