using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Rigidbody rb;
    public int ballspeed;
    public float jumpForce = 7;
    public SphereCollider col;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");

        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove * ballspeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
