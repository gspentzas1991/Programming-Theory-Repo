using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE -- Banana inherits from fruit

/// <summary>
/// Banans play a sound when they are destroyed
/// </summary>
public class Banana : Fruit
{
    [SerializeField]
    private AudioClip audioclip;

    // POLYMORPHISM
    override protected void DestroyFruit()
    {
        base.DestroyFruit();
        AudioSource.PlayClipAtPoint(audioclip, transform.position);
    }
}
