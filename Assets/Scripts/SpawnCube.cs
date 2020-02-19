using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpawnCube : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject itemToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnHandHoverBegin(Hand hand)
    {
        Instantiate(itemToSpawn, spawnLocation);
    }
}
