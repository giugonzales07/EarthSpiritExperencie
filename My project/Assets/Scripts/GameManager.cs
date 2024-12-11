using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 

    public Text score_visible;
    public int score;

    public GameOverScreen gameOverScreen;

    public void GameOver(){
        gameOverScreen.Setup(score);
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score_visible.text = "Points: " + score;
    }
}
