using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField]
     GameObject prefab;
    [SerializeField]
    int height;
    [SerializeField]
    int delaySeconds;
    int xPos;
    int zPos;
    int yPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrefabDrop());
    }

    IEnumerator PrefabDrop()
    {
       
            xPos = Random.Range(-45, 45);
            zPos = Random.Range(-45, 45);
            yPos = Random.Range(-360, 360);
            yield return new WaitForSeconds(delaySeconds);       
            Instantiate(prefab, new Vector3(xPos, height, zPos), Quaternion.Euler(xPos, yPos, zPos));
            yield return new WaitForSeconds(delaySeconds);
        Destroy(prefab);
                   
    }
}
