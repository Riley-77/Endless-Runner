using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Much like the start() and update() methods, OnTriggerEnter2D is a special Uniy method that is called
    //by Unity automatically at a specific point - in this case, when something enters te Trigger attached
    //to this GameObject
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the GameObjectt that has collided with our trigger is tagged with cleanup...
        if (collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
}
