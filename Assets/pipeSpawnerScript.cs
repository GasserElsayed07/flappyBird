using System.Threading;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRateTime = 2;

    // Screen height boundaries
    private float maxHeight;
    private float minHeight;
    private float timer = 2;

    void Start()
    {
        // Get screen height in world coordinates - simple approach
        float height = Camera.main.orthographicSize; // Half the height of the camera view
        maxHeight = height - 5f; // Subtract a small value to keep pipes visible
        minHeight = -height + 5f; // Add a small value to keep pipes visible
        
        Debug.Log("Screen Height: Max = " + maxHeight + ", Min = " + minHeight);
    }


    void Update()
    {
        if (timer < spawnRateTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // Spawn at random height between min and max
            Vector3 spawnPos = transform.position;
            spawnPos.y = Random.Range(minHeight, maxHeight);
            Instantiate(pipes, spawnPos, transform.rotation);
            timer = 0;
        }
    }
}
