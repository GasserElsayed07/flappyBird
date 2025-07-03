using UnityEngine;

public class birdScript : MonoBehaviour
{

    public new Rigidbody2D rigidbody2D;
    public float jumpSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.linearVelocity = Vector2.up * jumpSpeed; 
        }
    }
}
