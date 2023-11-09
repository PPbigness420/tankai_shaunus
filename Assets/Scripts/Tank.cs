using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotatespeed=90;
    


    public string vert = "Vertical";
    public string horz = "Horizontal";

    public KeyCode shot;

    public GameObject bullet;
    public Transform FirePoint;

    public AudioSource gunShot;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        var hor = Input.GetAxis(horz);
        var ver = Input.GetAxis(vert);

        
        //rb.velocity = transform.forward * speed * ver * Time.deltaTime;
        transform.position += transform.forward * speed * ver * Time.deltaTime;
        transform.Rotate(0,rotatespeed * hor * Time.deltaTime,0);

        if (Input.GetKeyDown(shot))
        {
            gunShot.Play();
            Instantiate(bullet,FirePoint.position,FirePoint.rotation);
        }
    }
}
