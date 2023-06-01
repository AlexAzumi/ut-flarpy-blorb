using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [Header("References")]
    public GameObject pipes;
    [Header("Properties")]
    public float spawnRate = 2.0f;
    public float heightOffset = 10.0f;

    private float timer = 0.0f;

    private void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer > spawnRate)
        {
            SpawnPipe();
            // Reset timer
            timer = 0.0f;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
