using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// 팩토리를 사용하는 스크립트
public class MonoFactory : MonoBehaviour
{
    public Button[] unitButtons;

    private void Awake()
    {
        // 유닛타입의 개수만큼 반복
        for (int i = 0; i < Enum.GetValues(typeof(UnitType)).Length;i++)
        {
            unitButtons[i].onClick.AddListener(delegate { OnButtonClick(i); });
        }
    }

    public void OnButtonClick(int num)
    {
        // 숫자 -> Enum
        UnitType type = (UnitType)num;
        Unit unit = UnitFactory.CreateUnit(type);
    }

}

