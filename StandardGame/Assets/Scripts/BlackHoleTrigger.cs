using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag.Equals("Player") == true)
        {
            SceneManager.LoadScene(0);
        }
    }
}
