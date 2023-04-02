using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobChaseAI : MonoBehaviour
{
    GameObject player;
    public float aggroRange = 10f;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if (distance <= aggroRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
