
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float spawnRate = 2f;
    public float obstacleSpeed = 4f;
    public float gapSize = 3f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        float gapCenter = Random.Range(-1f, 2f);
        float spawnX = 10f;

        CreateObstacle(
            new Vector2(spawnX, gapCenter + gapSize / 2f + 3f),
            new Vector2(1.5f, 6f)
        );

        CreateObstacle(
            new Vector2(spawnX, gapCenter - gapSize / 2f - 3f),
            new Vector2(1.5f, 6f)
        );
    }

    void CreateObstacle(Vector2 position, Vector2 scale)
    {
        GameObject obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);

        obstacle.name = "Dodge Obstacle";
        obstacle.transform.position = position;
        obstacle.transform.localScale = scale;

        ObstacleMovement movement = obstacle.AddComponent<ObstacleMovement>();
        movement.speed = obstacleSpeed;
    }
}
