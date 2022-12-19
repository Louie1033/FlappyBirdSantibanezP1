using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public float upForce = 200f;
    public AudioClip deathSound;
    public AudioClip scoreSound;
    
    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    AudioSource audioSource;
    
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown (KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
    }
    void OnCollisionEnter2D ()
    {
        audioSource.PlayOneShot(deathSound);
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameController.instance.BirdDied();
    }
    void OnTriggerEnter2D ()
    {
        audioSource.PlayOneShot(scoreSound);    
    }
}
