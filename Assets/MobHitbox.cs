using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHitbox : MonoBehaviour
{
    public Collider2D mobCollider;
    public MobBase mob;

    float timetoShoot = 0;
    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == false)
        {
            timetoShoot -= Time.deltaTime;
            if (timetoShoot <= 0)
            {
                canShoot = true;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        mob.Health -= damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && canShoot)
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();
            player.TakeDamage(mob.damage);
            canShoot = false;
            timetoShoot = 5;
        }
    }
}
