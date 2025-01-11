using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float spawnInterval = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBubble", 1f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBubble()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-2f, 2f),
            Random.Range(0.5f, 3f),
            Random.Range(1f, 3f)
        );
        Instantiate(bubblePrefab, randomPosition, Quaternion.identity);
    }
}
