using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour


    public float upForce = 200f;
    private bool isDead = false;
    private Rigidboddy2D rigidbody2d;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (input.GetMouseButtonDown (0))
            {
                rigidbody2d.velocity = Vector2.zero;
                rigidbody2d.addForce(
                    )
            }
        }
    }
}
