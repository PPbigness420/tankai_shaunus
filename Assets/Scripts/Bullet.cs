using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float time = 3f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
    void Update()
    {
        transform.position += transform.forward* speed * Time.deltaTime;
        
    }
}
