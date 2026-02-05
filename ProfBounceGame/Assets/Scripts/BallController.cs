using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    
    //Components Connected to the same gameObject as this one.
    Rigidbody myBod;
    AudioSource myAudio;

    //Components Connected to other gameObjects.
    GameMgr gm;

    public int maxJumps;
    public AudioClip bouceSound;
    public AudioClip exploSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //init my components
        myBod = GetComponent<Rigidbody>();
        myAudio = GetComponent<AudioSource>();

        //init other components
        gm = GameObject.Find("GM").GetComponent<GameMgr>();

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

        if(otherGO.name == "Player")
        {
            gm.increaseScore(1);
        }

        myAudio.PlayOneShot(bouceSound);


    }

    void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        print(otherGO.name);

        if(otherGO.name == "MagicSquare")
        {
            //clone ball
            GameObject g = Instantiate(gameObject);
            g.transform.position = new Vector3(0, 4, 0);
            gm.increaseBallCount(1);
        }
        else if(otherGO.name == "Floor") {
            myAudio.PlayOneShot(exploSound);
            gm.increaseBallCount(-1);
            Destroy(gameObject, 1.5f); //Destroy in 1.5 seconds
        }

    }
}
