using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    float playerStartPos;
    public float speed = 0.5f;
    void Start()
    {
        player = GameObject.Find("Square");
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        float offset = (player.transform.position.x - playerStartPos) * speed;
        //^^^^^^^^^^^^^^^^^^This lind finds out much to offset the texture by.
        //We do this by subtracting out starting X position  from our current X position.
        //We then multiply  the offset by the speed, so that we can have differen layers
        //moving at different speeds

        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
        //^^^^^^^^^^^^^^^^^^^^This line sets our textures 'offset'. We use the
        //SetTextureOffset method to do this, which take 2 parameters.
        //The first parameter is a string that refers to the texture we want to modify
        //The second parameter is a Vector2, with the first (x) variable shifting the texture
        //Left and Right, and the second (Y) variable shifting the texture up and down.
    }
}
