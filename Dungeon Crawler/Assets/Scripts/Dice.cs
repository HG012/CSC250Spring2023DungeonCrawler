using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice // we call class methods using the name of the class in which the method was defined!
{
    public static int roll(int sides)
    {
       return Random.Range(1, sides + 1)

    }
}
