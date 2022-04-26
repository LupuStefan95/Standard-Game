using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    int score;

    private void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log(score);
    }

}
