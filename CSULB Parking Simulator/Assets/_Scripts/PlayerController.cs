using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    public float speed;
    public Boundary boundary;
    public float rotation;
    private Rigidbody rb;
    public float velocity;
    public float RotateSpeed;
    public float maxVelocityX;
    public float maxVelocityZ;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
       // rb.velocity = movement * speed;

        var maxVelocityX = 2f;
        var maxVelocityZ = 2f;
        rb.AddForce(movement * speed * Time.deltaTime * 1000);
        rb.velocity = new Vector3
            (
            Mathf.Clamp(rb.velocity.x, -maxVelocityX, maxVelocityX),
            0.0f,
            Mathf.Clamp(rb.velocity.z, -maxVelocityX, maxVelocityZ)
            );

        this.transform.LookAt(this.transform.position + (rb.velocity).normalized, Vector3.up);
        

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        //}

        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        //}

        //rb.position = new Vector3
        //    (
        //    Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 
        //    0.0f,
        //    Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        //    );
    }
}
