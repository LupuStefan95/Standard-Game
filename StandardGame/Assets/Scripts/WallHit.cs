using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject.name == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.green;
        Debug.Log("Bumped");
        }
        
    }
}
