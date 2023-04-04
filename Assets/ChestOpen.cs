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
        chestAnim.SetBool("ChestOpen", true);
        chest.ShowItem();
    }
}
