using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelFinish3 : MonoBehaviour
{
    
    private TilemapCollider2D platforms;

    void Start()
    {
        platforms = GetComponent<TilemapCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Boss") == null)
        {
            platforms.enabled = false;
            platforms.GetComponent<TilemapRenderer>().enabled = false;
        }
    }
}
