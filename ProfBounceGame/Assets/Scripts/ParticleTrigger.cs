using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    ParticleSystem myPS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPS = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        myPS.Play();
    }
}
