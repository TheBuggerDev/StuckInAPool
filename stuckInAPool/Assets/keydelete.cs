using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keydelete : MonoBehaviour
{
    public static bool deleteKey1 = false;

    private void Start()
    {
        deleteKey1 = false;
    }
    void Destroykey1()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (deleteKey1 == true)
        {
            Destroykey1();
        }
    }
}
