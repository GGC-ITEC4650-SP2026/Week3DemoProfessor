using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        print(otherGO.name);
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        print(otherGO.name);
    }
}
