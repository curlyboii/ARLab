using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject Character;

    private void OnCollisionEnter(Collision collision)
    {
        Character.GetComponent<Animation>().Play("dancing");
    }

    private void OnCollisionExit(Collision collision) 
    
    {

        Character.GetComponent<Animation>().Play("Idle");
    
    }
}
