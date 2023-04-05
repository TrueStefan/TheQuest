using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public float totalHealth;
    public TextMeshProUGUI TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level1"){
            totalHealth = 10; 
        }else{
            totalHealth = healthcheck.totalHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        totalHealth = healthcheck.totalHealth;
        float totalHealth2 = Mathf.FloorToInt(totalHealth);
        TimerTxt.text = string.Format("Health: " + "{000}",totalHealth2);

    }
}
