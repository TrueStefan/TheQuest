using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public WeightedRandomList<Transform> lootTable;

    public Transform itemHolder;

    Animator animator;

    bool hasGivenItem = false; // track whether the chest has already given an item

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        itemHolder.gameObject.SetActive(false); // set the itemHolder to be inactive initially
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowItem(){
        if (!hasGivenItem) { // only give an item if the chest hasn't given one before
            Debug.Log("Showing item!");
            Transform item = lootTable.GetRandom();
            Instantiate(item, itemHolder.position, itemHolder.rotation, itemHolder);
            StartCoroutine(ActivateItemHolder()); // activate the itemHolder after a delay
            hasGivenItem = true; // set the flag to true to indicate that the chest has given an item
        }
    }

    IEnumerator ActivateItemHolder()
    {
        // Wait for the chest to finish opening before activating the itemHolder
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        itemHolder.gameObject.SetActive(true);
    }
}
