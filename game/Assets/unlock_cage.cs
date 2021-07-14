using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock_cage : MonoBehaviour
{
    public Rigidbody rig1;
    public Rigidbody rig2;


    public void unlockCage()
    {
        rig1.constraints = RigidbodyConstraints.None;
        rig2.constraints = RigidbodyConstraints.None;
    }


}
