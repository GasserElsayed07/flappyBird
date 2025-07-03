using UnityEngine;

public class PipesMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float pipeSpeed = 5;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
