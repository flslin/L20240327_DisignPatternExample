using UnityEngine;

public class Firebat : Unit1
{
    private void Start()
    {
        Debug.Log("Need a light?");
    }

    public override void Attack()
    {
        Debug.Log("Let's burn!");
    }
}