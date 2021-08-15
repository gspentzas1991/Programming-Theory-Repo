using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Rigidbody fruitRigidbody;
    private float torqueForce = 100f;
    [SerializeField]
    private int m_scoreValue;
    // ENCAPSULATION
    public int scoreValue
    {
        get { return m_scoreValue; }
        private set { m_scoreValue = value; }

    }
    [SerializeField]
    private ParticleSystem destructionParticle;

    protected ScoreHandler scoreHandler;

    private void Start()
    {
        fruitRigidbody = GetComponent<Rigidbody>();
        scoreHandler = GameObject.Find("ScoreManager").GetComponent<ScoreHandler>();
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

    // POLYMORPHISM
    protected virtual void DestroyFruit()
    {
        var particle = Instantiate(destructionParticle, transform.position, destructionParticle.transform.rotation);
        particle.Play();
        Destroy(gameObject);
        scoreHandler.IncreaseScore(scoreValue);
    }
}
