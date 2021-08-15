using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    private float spawnRange = 10f;
    private float spawnRate = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomFruit());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Spawns a random fruit prefab then waits for some seconds, 
    /// according to the spawnRate property
    /// </summary>
    IEnumerator SpawnRandomFruit()
    {
        var randomFruit = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];
        var randomPosition = transform.position;
        randomPosition.x = Random.Range(-spawnRange, spawnRange);
        Instantiate(randomFruit, randomPosition, randomFruit.transform.rotation);
        yield return new WaitForSeconds(spawnRate);
        StartCoroutine(SpawnRandomFruit());
    }
}
