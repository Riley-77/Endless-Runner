using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerObject;
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal");

        playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);
    }
}
