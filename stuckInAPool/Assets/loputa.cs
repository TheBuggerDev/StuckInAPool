using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loputa : MonoBehaviour
{
    public static bool loputaon = false;
    private void Start()
    {
        loputaon = false;
    }
    private void Update()
    {
        if(loputaon == true)
        {
            die();
        }
    }
    void die() => Destroy(gameObject);

}
