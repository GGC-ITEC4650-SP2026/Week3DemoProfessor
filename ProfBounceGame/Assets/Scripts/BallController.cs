using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    
    Rigidbody myBod;
    AudioSource myAudio;

    Text scoreTxt;

    private int score;

    public int maxJumps;
    public AudioClip bouceSound;
    public AudioClip exploSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myBod = GetComponent<Rigidbody>();
        myAudio = GetComponent<AudioSource>();
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
        score = 0;

        float x = Random.Range(-5f, 5f);
        myBod.linearVelocity = new Vector3(x, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && maxJumps > 0)
        {
            maxJumps--;
            myBod.linearVelocity = new Vector3(
                myBod.linearVelocity.x, 
                10,
                0
            );
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherGO = collision.gameObject;
        print(otherGO.name);

        if(otherGO.name == "Player") {
            score += 1;
            scoreTxt.text = "Score: " + score;
        }

        myAudio.PlayOneShot(bouceSound);


    }

    void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        print(otherGO.name);

        myAudio.PlayOneShot(exploSound);

    }
}
