using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public float spawnRate = 1.5f;
    public Vector3 spawnArea = new Vector3(10, 0, 10);

    void Start()
    {
        InvokeRepeating("SpawnSomething", 1f, spawnRate);
    }

    void SpawnSomething()
    {
        Vector3 pos = new Vector3(
            Random.Range(-spawnArea.x, spawnArea.x),
            0.5f,
            Random.Range(-spawnArea.z, spawnArea.z)
        );

        int index = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[index], pos, Quaternion.identity);
    }
}