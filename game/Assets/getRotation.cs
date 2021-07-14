using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getRotation : MonoBehaviour
{

    public GameObject camRotation;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        gameObject.transform.rotation = camRotation.transform.rotation;
    }
}
