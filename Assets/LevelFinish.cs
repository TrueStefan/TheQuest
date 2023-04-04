using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelFinish : MonoBehaviour
{
    
    private TilemapCollider2D platforms;

    void Start()
    {
        platforms = GetComponent<TilemapCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            platforms.enabled = false;
            platforms.GetComponent<TilemapRenderer>().enabled = false;
        }
    }
}
