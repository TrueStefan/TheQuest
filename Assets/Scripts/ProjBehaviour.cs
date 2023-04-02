using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjBehaviour : MonoBehaviour
{
    public float damage = 6f;
    public float speed = 5f;
    Transform playerPosition;
    Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        direction = Vector3.Normalize(playerPosition.position - transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
}
