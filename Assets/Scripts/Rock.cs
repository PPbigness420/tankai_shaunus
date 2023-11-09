using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject sRock;
    
    public int Health;

    public AudioSource hitSFX;
    public AudioSource destroySFX;

    private void OnCollisionEnter(Collision collision)
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
    private void OnCollisionStay(Collision collision)
    {
        
        if (collision.gameObject.name.Contains("Tank"))
        {
            destroySFX.Play();
            Destruction();
        }   
    }
    void Destruction()
    {

        
        Destroy(gameObject);
        sRock.transform.position = gameObject.transform.position;
        Instantiate(sRock);
    }
}
