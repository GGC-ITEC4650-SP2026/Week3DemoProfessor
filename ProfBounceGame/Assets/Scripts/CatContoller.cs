using UnityEngine;

public class CatContoller : MonoBehaviour
{
    Animator myAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        myAnim.SetBool("JUMP", true);
    }
    void OnTriggerExit(Collider other)
    {
        myAnim.SetBool("JUMP", false);
    }
}
