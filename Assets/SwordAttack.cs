using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    Vector2 rightAttackOffset;
    public Collider2D swordCollider;

    public float damage = 5;

    void Start()
    {
        rightAttackOffset = transform.localPosition;
    }

    public void AttackRight()
    {
        //print("Attack Right");
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft()
    {
        print("Attack Left");
        swordCollider.enabled = true;
        transform.localPosition = new Vector2(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Mob")
        {
            MobHitbox mob = collision.GetComponent<MobHitbox>();
            print(mob);

            if (mob != null)
            {
                mob.TakeDamage(damage);
            }
        }

        if (collision.gameObject.tag == "Totem")
        {
            MobBase mob = collision.GetComponent<MobBase>();
            print(mob);

            if (mob != null)
            {
                mob.TakeDamage(damage);
            }
        }
    }
}
