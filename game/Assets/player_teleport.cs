using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_teleport : MonoBehaviour
{

    public GameObject teleportTo;



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = teleportTo.transform.position;
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 20f);
        }
    }

}
