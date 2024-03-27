using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit1 : MonoBehaviour
{
    public abstract void Attack();
}

public class Firebat : Unit1
{
    private void Start()
    {
        Debug.Log("Need a light?");
    }

    public override void Attack()
    {
        Debug.Log("Lget's burn!");
    }
}

public class Marine : Unit1
{
    private void Start()
    {
        Debug.Log("You anna piece of me, boy?");
    }

    public override void Attack()
    {
        Debug.Log("Go go go!");
    }
}
