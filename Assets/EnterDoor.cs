using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hello");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
