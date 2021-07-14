using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class detect_tag_trigger : MonoBehaviour
{
    [SerializeField]UnityEvent m_MyEvent;
    
    public Transform areaCamPos;

    public GameObject mainCamera;


    void Start()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Ping);
    }

    void Update()
    {
      
    }

    void Ping()
    {
        Debug.Log("Ping");
        mainCamera.transform.position = areaCamPos.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            m_MyEvent.Invoke();
        }
    }

}
