using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0;
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
        if(temp.x > -9f && temp.x < 9f) {
            transform.position = temp;
        }

        // if game is paused and player clicks, then resume game
        if(Time.timeScale == 0 && Input.GetButtonDown("Fire1"))
        {
            Time.timeScale = 1;
        }
        
    }
}
