using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefab;
    public int xPos;
    public int zPos;
    public int prefabsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrefabDrop());
    }

    IEnumerator PrefabDrop()
    {
        if (prefabsCount < 10)
        {
            xPos = Random.Range(-45, 45);
            zPos = Random.Range(-45, 45);
            yield return new WaitForSeconds(5);
            Instantiate(prefab, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(5);
            Destroy(prefab);
            //prefabsCount += 1;
        }
    }
}
