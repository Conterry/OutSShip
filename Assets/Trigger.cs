using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Sea")
        {
            print("7548654872654");
        }
    }
}   
