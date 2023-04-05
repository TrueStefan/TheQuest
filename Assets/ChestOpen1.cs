using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen1 : MonoBehaviour
{
    private Animator chestAnim;
    public Chest chest; // reference to the Chest script component

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
        if (GameObject.Find("ShootMob (1)") == null && GameObject.Find("ShootMob (2)") == null && GameObject.Find("ShootMob") == null){
            GameObject.Find ("Chest").transform.localScale = new Vector3(0.3f, 0.28f, 1f);
            chestAnim = GetComponent<Animator>();
            Debug.Log("Starting state:" + chestAnim.GetBool("ChestOpen"));
            chestAnim.SetBool("ChestOpen", true);
            chest.ShowItem();
        }
    }
}
