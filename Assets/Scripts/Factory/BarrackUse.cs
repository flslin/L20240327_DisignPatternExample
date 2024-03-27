using System.Collections;
using UnityEngine;

public class BarrackUse : MonoBehaviour
{
    BarrackFactory barrackFactory = null;
    GameObject unit1;
    GameObject unit2;

    private void Start()
    {
        barrackFactory = GetComponent<BarrackFactory>();

        unit1 = barrackFactory.CreateUnit(UnitType1.Marine);
        unit2 = barrackFactory.CreateUnit(UnitType1.FireBat);

        StartCoroutine("UnitAction");
    }

    IEnumerator UnitAction()
    {
        yield return new WaitForSeconds(0.2f);

        unit1.GetComponent<Unit1>().Attack();
        unit2.GetComponent<Unit1>().Attack();
    }
}

