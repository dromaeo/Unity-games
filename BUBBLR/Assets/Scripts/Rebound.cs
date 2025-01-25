using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour
{
    public bool Wall;
    public bool Bubble;
    
    public float WallForce;
    public float BubbleForce;

    public Rigidbody2D rb;
    public AudioSource WallSound;
    public AudioSource BubbleSound;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
      if(Wall == true)
      {
       other.rigidbody.AddForce(-other.contacts[0].normal * WallForce, ForceMode2D.Impulse);
       //WallSound.Play();
      }

      if(Bubble == true)
      {
       other.rigidbody.AddForce(-other.contacts[0].normal * BubbleForce, ForceMode2D.Impulse);
       //BubbleSound.Play();
      }
    }    
}
