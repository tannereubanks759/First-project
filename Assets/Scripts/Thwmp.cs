using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwmp : MonoBehaviour
{
    private void OnTriggerEnter2d(Collider2D collision)
    {
        //Destroy the other object
        
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Debug.Log("trigger");
        }
    }
}
