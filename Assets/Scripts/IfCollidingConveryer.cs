using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCollidingConveryer : MonoBehaviour
{
    public float thrust;
    private Vector3 direction;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(direction * 2.0f, ForceMode.Acceleration);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ConveyerBelt")
        {
            //transform.SetParent(collision.transform);
            direction = collision.transform.forward;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "ConveyerBelt")
        {

            //transform.Translate(direction* Time.deltaTime);
            
            rb.AddForce(direction* thrust, ForceMode.Acceleration);
        }
    }


}
