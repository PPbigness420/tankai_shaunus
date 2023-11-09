using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Particle : MonoBehaviour
{
    public GameObject particle;

    public int Health;

    public AudioSource hitSFX;
    public AudioSource destroySFX;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.Contains("Ground")&& !collision.gameObject.name.Contains("Rock") && !collision.gameObject.name.Contains("Cactus"))
        {
            
            Health--;
            if (Health>0)
            {
                hitSFX.Play();
                
            }
            else
            {
                destroySFX.Play();
                Destruction();
            }
        }
        

    }
    
    void Destruction()
    {

        
        Destroy(gameObject);
        particle.transform.position = gameObject.transform.position;
        Instantiate(particle);
    }
}
