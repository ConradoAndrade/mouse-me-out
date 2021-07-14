using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class players_controllers : MonoBehaviour
{

    public CinemachineVirtualCamera mainCamera;

    public GameObject player1;
    public GameObject player2;

    public GameObject dummi;


    public int isPlayer = 1;


    void Start()
    {
        
    }
        
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            changePlayer();
        }
    }

    public void changePlayer()
    {
        //PARA OS DOIS TRABALHAREM JUNTOS, É PRECISO RESOLVER O PROBLEMA DE ATIVAR A CAMERA POR ONTRIGGER ENTER ' ESPERO QUE TU ENTENDA O TEU EU DO PASSADO
        Debug.Log("isPlayer " + isPlayer);

        if (isPlayer == 1)
        {
            player1.SetActive(true);
            player2.SetActive(false);
            dummi.SetActive(false);

            // player1.transform.GetComponent<SimpleCharacterController>().enabled = true;
            //player2.transform.GetComponent<SimpleCharacterController>().enabled = false;

            mainCamera.LookAt = player1.transform;

            isPlayer = 2;
        }
        else if(isPlayer == 2)
        {
            player1.SetActive(false);
            player2.SetActive(true);
            dummi.SetActive(true);

            //if(!player2.activeSelf)
            //player2.SetActive(true);

            //player1.transform.GetComponent<SimpleCharacterController>().enabled = false;
            //player2.transform.GetComponent<SimpleCharacterController>().enabled = true;

            mainCamera.LookAt = player2.transform;

            isPlayer = 1;
        }


    }
}
