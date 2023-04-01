using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 speed = new Vector2(50,50);

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX / 4, speed.y * inputY / 4, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);    
    }
}
