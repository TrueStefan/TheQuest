using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private Animator chestAnim;
    public Chest chest; // reference to the Chest script component

    void Start()
    {
        chestAnim = GetComponent<Animator>();
        Debug.Log("Starting state:" + chestAnim.GetBool("ChestOpen"));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            chestAnim.SetBool("ChestOpen", true);
            Debug.Log("After collision state:" + chestAnim.GetBool("ChestOpen"));
            chest.ShowItem(); // call the ShowItem() function of the Chest script component
        }
    }
}
