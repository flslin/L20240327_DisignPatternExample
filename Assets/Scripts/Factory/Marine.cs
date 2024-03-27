using UnityEngine;

public class Marine : Unit1
{
    private void Start()
    {
        Debug.Log("You wanna piece of me, boy?");
    }

    public override void Attack()
    {
        Debug.Log("Go go go!");
    }
}