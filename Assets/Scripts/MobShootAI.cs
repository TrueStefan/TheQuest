using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobShootAI : MonoBehaviour
{
    public GameObject projectile;
    public float aggroRange = 15f;
    public Animator animator;
    public float fireRate = 1f;
    float timeToShoot = 0;
    bool canShoot = true;

    GameObject player;
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
            if (canShoot == false)
            {
                timeToShoot -= Time.deltaTime;
                if (timeToShoot <= 0)
                {
                    canShoot = true;
                }
            }

            float distance = Vector2.Distance(player.transform.position, transform.position);
            if (distance <= aggroRange && canShoot)
            {
                if (animator != null)
                {
                    animator.SetBool("isShooting", true);
                }
                canShoot = false;
                timeToShoot = 1.0f / fireRate;
                GameObject newProj = Instantiate(projectile, transform.position, transform.rotation);
                Destroy(newProj, 8f);
            }
            if (animator != null)
            {
                animator.SetBool("isShooting", false);
            }
        }
    }
}
