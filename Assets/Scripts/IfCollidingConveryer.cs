using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCollidingConveryer : MonoBehaviour
{
    private Vector3 direction;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Debug.Log(direction);
            transform.Translate(direction* Time.deltaTime);
            //rb.AddForce(direction, ForceMode.Acceleration);
        }
    }


}
