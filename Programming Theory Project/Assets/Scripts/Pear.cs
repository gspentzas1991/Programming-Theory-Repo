using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE -- Pear inherits from fruit

/// <summary>
/// Pears spawn an apple when they are destroyed
/// </summary>
public class Pear : Fruit
{
    [SerializeField] private GameObject applePrefab;

    override protected void DestroyFruit()
    {
        base.DestroyFruit();
        Instantiate(applePrefab, transform.position, transform.rotation);
    }
}
