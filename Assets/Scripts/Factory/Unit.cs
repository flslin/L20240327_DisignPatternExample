using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// 팩토리로 생성할 오브젝트에 대한 설계

public abstract class Unit
{
    public abstract void move();
    public abstract void select();

    public abstract void command();
}

public class Vulture : Unit
{
    public Vulture()
    {
        Debug.Log("Alright! Bring on it!");
    }

    public override void command()
    {
        //Random random = new Random();
        //int rand = random.Next(4);
        int rand = Random.Range(0, 4);

        switch (rand)
        {
            case 0:
                Debug.Log("Yeah, I'm going!");
                break;
            case 1:
                Debug.Log("I dig.");
                break;
            case 2:
                Debug.Log("No problem.");
                break;
            case 3:
                Debug.Log("Oh... is that it?");
                break;
        }

    }

    public override void move()
    {
    }

    public override void select()
    {
    }
}

public class SiegeTank : Unit
{
    public SiegeTank()
    {
        Debug.Log("Ready to roll out!");
    }

    public override void command()
    {
    }

    public override void move()
    {
    }

    public override void select()
    {
    }
}

public class Goliath : Unit
{
    public Goliath()
    {
        Debug.Log("Goliath online");
    }

    public override void command()
    {
    }

    public override void move()
    {
    }

    public override void select()
    {
    }
}