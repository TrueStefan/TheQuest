using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float CurrentTime;
    public TextMeshProUGUI TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level1"){
            CurrentTime = 300; 
        }else{
            CurrentTime = Scoring.totalScore;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        Scoring.totalScore = CurrentTime;
        UpdateTimer(CurrentTime);
    }

    void UpdateTimer(float currentTime){
        currentTime += 1;
        float seconds = Mathf.FloorToInt(currentTime);

        TimerTxt.text = string.Format("Score: "+"{000}",seconds);
    }
}
