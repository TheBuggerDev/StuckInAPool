using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keydelete2 : MonoBehaviour
{
    public static bool deleteKey2 = false;
    private void Start()
    {
        deleteKey2 = false;
    }
    void Destroykey2()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (deleteKey2 == true)
        {
            Destroykey2();
        }
    }
}
