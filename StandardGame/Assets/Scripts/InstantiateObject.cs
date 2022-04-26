using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField]
     GameObject prefab;
    [SerializeField]
    int xPos;
    [SerializeField]
    int zPos;
 
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrefabDrop());
    }

    IEnumerator PrefabDrop()
    {
       
            xPos = Random.Range(-45, 45);
            zPos = Random.Range(-45, 45);
            yield return new WaitForSeconds(2);
            Instantiate(prefab, new Vector3(xPos, 15, zPos), Quaternion.identity);
            yield return new WaitForSeconds(2);
        Destroy(prefab);
                   
    }
}
