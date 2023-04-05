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
        if (player != null)
        {
            float distance = Vector2.Distance(player.transform.position, transform.position);
            if (distance <= aggroRange)
            {
                Vector3 direction = player.transform.position - transform.position;
                Vector3 movement = direction.normalized * speed * Time.deltaTime;
                if (movement.magnitude > direction.magnitude)
                    movement = direction;
                GetComponent<CharacterController>().Move(movement);
            }
        }
    }
}
