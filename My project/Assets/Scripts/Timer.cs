using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float remainingTime;

    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0){
            remainingTime -= Time.deltaTime;
        } else if (remainingTime < 0){
            remainingTime = 0;
            timerText.color = Color.red;
            gameManager.GameOver();
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void AddTime(){
        remainingTime += 30;
    }

    public void SubTime(){
        remainingTime -= 10;
    }
}
