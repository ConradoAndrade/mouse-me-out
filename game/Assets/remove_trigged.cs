using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_trigged : MonoBehaviour
{


    public void remove()
    {
        Debug.Log("apagado");

        GameObject.Destroy(gameObject);
    }

    public void release()
    {
        Debug.Log("solto");

        gameObject.GetComponent<Rigidbody>().isKinematic = false ;
    }

}
