using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterialAction : MonoBehaviour
{
    public Material active;

    public bool state;

    public void changeIfActive()
    {

        if (!state)
        {
            gameObject.GetComponent<MeshRenderer>().material = active;
            state = true;
        }

    }

}
