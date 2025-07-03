using System.Threading;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{

    public GameObject pipes;
    public float spawnRateTime = 2;

    private float timer = 2;

    void Start()
    {
    }


    void Update()
    {
        if (timer < spawnRateTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pipes, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
