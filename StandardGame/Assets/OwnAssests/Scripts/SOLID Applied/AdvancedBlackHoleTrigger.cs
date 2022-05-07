using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedBlackHoleTrigger :  BlackHoleTrigger
{
    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello");
            Destroy(this);
        }
    }
}
