using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float maxVelocityX;
    public float maxVelocityZ;
    public GameObject winText;
    public GameObject lossText;


    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.SetActive(false);
        lossText.SetActive(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        var maxVelocityX = 2f;
        var maxVelocityZ = 2f;

        rb.AddForce(movement * speed * Time.deltaTime * 1000);
        rb.velocity = new Vector3
            (
            Mathf.Clamp(rb.velocity.x, -maxVelocityX, maxVelocityX),
            0.0f,
            Mathf.Clamp(rb.velocity.z, -maxVelocityZ, maxVelocityZ)
            );
        this.transform.LookAt(this.transform.position + (rb.velocity).normalized, Vector3.up);

    }

    public void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "barriers")
        {
            winText.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
