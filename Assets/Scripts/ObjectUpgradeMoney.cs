using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectUpgradeMoney : MonoBehaviour
{
    public Material red;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ConveyObj")
        {
            other.GetComponent<Renderer>().material = red;
        }
        
    }
}
