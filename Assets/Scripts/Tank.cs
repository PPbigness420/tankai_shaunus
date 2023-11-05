using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotatespeed=90;
    public float bulspeed;


    public string vert = "Vertical";
    public string horz = "Horizontal";

    public KeyCode shot;

    public GameObject bullet;

    void Start()
    {
        
    }

  
    void Update()
    {
        var hor = Input.GetAxis(horz);
        var ver = Input.GetAxis(vert);


        transform.position += transform.forward * speed * ver * Time.deltaTime;
        transform.Rotate(0,rotatespeed * hor * Time.deltaTime,0);

        if (Input.GetKeyDown(shot))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        }
    }
}
