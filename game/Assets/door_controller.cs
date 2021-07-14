using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_controller : MonoBehaviour
{

    public GameObject closedDoor;
    public GameObject openedDoor;

    public AudioSource opensound;

    bool state = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stateDoor( )
    {
        if (!state)
        {
            state = true;
            openedDoor.SetActive(true);
            closedDoor.SetActive(false);
            opensound.Play();
        }
        
    }
}
