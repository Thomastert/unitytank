using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    Rigidbody rb;
    public float rotationspeed = 8.5f;
    public float movespeed = 5f;
    private Transform[] transforms;
    protected Transform turret;
    protected Vector3 targetPos;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void undoVelocity()
    {
        if (rb.velocity != Vector3.zero)
        {
            rb.velocity = Vector3.zero;
        }
        if (rb.angularVelocity != Vector3.zero)
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
    void playerMovement ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * movespeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * movespeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * rotationspeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationspeed);
        }
    }
    protected virtual void update()
    {
        transforms = gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "turret")
            {
                turret = t;
            }
        }

    }
    void determineWorldPos() 

    {
        turret.LookAt(targetPos);
    
    
    
    }
}
