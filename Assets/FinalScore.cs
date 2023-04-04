using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI ScoreTxt;
    public float Score;

    public void Start(){
        Score = Scoring.totalScore;
        float seconds = Mathf.FloorToInt(Score);
        ScoreTxt.text = string.Format("{000}",seconds);
    }
}
