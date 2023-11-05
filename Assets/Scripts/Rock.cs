using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public GameObject sRock;

    private void OnCollisionEnter(Collision collision)
    {
        if (!gameObject.gameObject.name.Contains("Ground"))
        {
           
            Destroy(gameObject);
            sRock.transform.position = gameObject.transform.position;
            Instantiate(sRock);
        }
    }
}
