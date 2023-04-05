using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHitbox : MonoBehaviour
{
    public Collider2D mobCollider;

    public MobBase mob;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        mob.Health -= damage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("mob collided");
        if (collision.gameObject.tag == "Player")
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            print(player);
            //something like this
            //health -= collision.gameObject.GetComponent<PlayerAttack>().damage;
        }
    }
}
