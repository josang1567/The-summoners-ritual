using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Drop")
        {
            Debug.Log(collision.gameObject.name);
            GameManager.gm.changeState(collision.gameObject.name);
            Destroy(collision.gameObject);

        }
    }
    

   
}
