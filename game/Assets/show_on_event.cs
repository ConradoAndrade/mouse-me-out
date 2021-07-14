using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_on_event : MonoBehaviour
{

    public GameObject toActive;

    public void show()
    {
        toActive.SetActive(true);
    }
}
