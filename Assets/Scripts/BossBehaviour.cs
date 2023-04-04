using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    public GameObject projectile;
    public float speed = 6f;
    public GameObject[] positions;
    
    int index = 0;
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
        if (canShoot == false)
        {
            timeToShoot -= Time.deltaTime;
            if (timeToShoot <= 0)
            {
                canShoot = true;
            }
        }
        if (canShoot)
        {
            canShoot = false;
            timeToShoot = 1.0f / fireRate;
            Vector3 dir = (player.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            for (int i = -2; i <= 2; i++)
            {
                GameObject newProj = Instantiate(projectile, transform.position, transform.rotation);
                newProj.transform.Rotate(0, 0, angle + i*10);
                Destroy(newProj, 8f);
            }
            
        }
        transform.position = Vector2.MoveTowards(transform.position, positions[index].transform.position, speed * Time.deltaTime);
        if (transform.position == positions[index].transform.position)
        {
            index = Random.Range(0, positions.Length);
        }
    }
}
