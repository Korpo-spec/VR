using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SpawnCube : MonoBehaviour
{
    public ISteamVR_Action_Boolean gripAction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool hey = gripAction.state;

        print(hey);
    }
}
