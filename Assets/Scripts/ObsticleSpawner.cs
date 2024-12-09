using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    public float minY = -2.8f;
    public float maxY = 0.5f;
    public float spawnX = 3f;

    private void Start(){
        // Start spawning obstacles repeatedly
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }

    private void SpawnObstacle(){
        // Randomize the y-position
        float randomY = Random.Range(minY, maxY);

        // Spawn the obstacle at the randomized position
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}