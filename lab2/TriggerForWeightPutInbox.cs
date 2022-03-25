using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForWeightPutInbox : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Weight"))
        {
            other.tag = "dragWeight";
			
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Weight"))
        {
            Destroy(other.gameObject);
            
        }
        
    }
}
