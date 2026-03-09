using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.up;
        transform.position += dir * speed * Time.deltaTime;
        
    }
}
