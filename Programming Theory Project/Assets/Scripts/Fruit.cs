using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Rigidbody fruitRigidbody;
    private float torqueForce = 100f;
    [SerializeField]
    //ENCAPSULATION
    public int scoreValue { get; private set; }

    [SerializeField]
    private ParticleSystem destructionParticle;

    void Start()
    {
        fruitRigidbody = GetComponent<Rigidbody>();
        ApplyRotation();
    }

    private void ApplyRotation()
    {
        fruitRigidbody.AddTorque(new Vector3(0, torqueForce, 0));
    }

    private void OnMouseDown()
    {
        DestroyFruit();
    }

    protected virtual void DestroyFruit()
    {
        destructionParticle.Play();
    }
}
