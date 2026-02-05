using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameMgr : MonoBehaviour
{

    Text scoreTxt;
    private int score;

    private int ballCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
        score = 0; 
        ballCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore(int n)
    {
        this.score += n;
        scoreTxt.text = "Score: " + score;
    }

    public void increaseBallCount(int n)
    {
        this.ballCount += n;
        if(ballCount <= 0) {
            SceneManager.LoadScene(0);
        }
    }
}
