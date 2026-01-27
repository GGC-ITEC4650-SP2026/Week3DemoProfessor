using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        Vector3 frameStep = dir * speed * Time.deltaTime;
        Vector3 temp = transform.position + frameStep;

        //constraints on movement

        transform.position = temp;
        
    }
}
