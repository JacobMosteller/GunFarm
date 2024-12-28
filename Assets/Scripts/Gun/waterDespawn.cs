using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterDespawn : MonoBehaviour
{
    [SerializeField] public Object objectToDestroy;
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(1.5f);

        Destroy(objectToDestroy);

    }
}
