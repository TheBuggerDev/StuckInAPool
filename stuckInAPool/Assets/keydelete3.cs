using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keydelete3 : MonoBehaviour
{
    public static bool deleteKey3 = false;
    private void Start()
    {
        deleteKey3 = false;
    }
    void Destroykey3()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (deleteKey3 == true)
        {
            Destroykey3();
        }
    }
}
