using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigger_player : MonoBehaviour
{
    [SerializeField] UnityEvent m2_MyEvent;



    void Start()
    {
        if (m2_MyEvent == null)
            m2_MyEvent = new UnityEvent();

    }

    void Update()
    {

    }



    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigged");

        if (other.gameObject.CompareTag("Player"))
        {
            m2_MyEvent.Invoke();
        }
    }

}
