using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private Animator chestAnim;
    public Chest chest; // reference to the Chest script component
    public float score = 50;
    void Start()
    {
        GameObject.Find ("Chest").transform.localScale = new Vector3(0, 0, 0);
        //chestAnim = GetComponent<Animator>();
        //Debug.Log("Starting state:" + chestAnim.GetBool("ChestOpen"));
        //chestAnim.SetBool("ChestOpen", true);
        //chest.ShowItem();
    }

    void Update()
    {
        if (GameObject.Find("ChaseMob (1)") == null && GameObject.Find("ChaseMob (2)") == null && GameObject.Find("ChaseMob") == null){
            Scoring.totalScore += score;
            GameObject.Find ("Chest").transform.localScale = new Vector3(0.3f, 0.28f, 1f);
            chestAnim = GetComponent<Animator>();
            Debug.Log("Starting state:" + chestAnim.GetBool("ChestOpen"));
            chestAnim.SetBool("ChestOpen", true);
            chest.ShowItem();
        }
    }
}
