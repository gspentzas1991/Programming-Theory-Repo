using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE -- Apple inherits from fruit
/// <summary>
/// Apples write a debug message when they get destroyed
/// </summary>
public class Apple : Fruit
{
    // POLYMORPHISM
    override protected void  DestroyFruit()
    {
        base.DestroyFruit();
        Debug.Log("Destroyed an apple!");
    }
}
