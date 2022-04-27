using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCube : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    int height;
    [SerializeField]
    int delaySeconds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrefabDrop());
    }

    IEnumerator PrefabDrop()
    {
        yield return new WaitForSeconds(delaySeconds);
       Instantiate(prefab, new Vector3(
             GameObject.FindGameObjectWithTag("Player").transform.position.x,
             height,
            GameObject.FindGameObjectWithTag("Player").transform.position.z), Quaternion.identity);
        // Instantiate(prefab, new Vector3(xPos, height, zPos), Quaternion.identity);
        yield return new WaitForSeconds(delaySeconds);
        Destroy(prefab);

    }
}
