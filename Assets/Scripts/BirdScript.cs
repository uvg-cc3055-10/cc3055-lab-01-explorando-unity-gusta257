using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public float fuerza = 200f;
    public float forwardSpeed = 6f;
    public bool dead = false;
    public GameObject cam;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.position.x >= 50)
        {
            dead = true;
            rb.MoveRotation(270f);
           
        }
        
        if(dead == false){

            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * fuerza);
            }

        }
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
        rb.MoveRotation(270f);
    }

}
