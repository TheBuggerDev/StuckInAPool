using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class keysystem : MonoBehaviour
{
    public  int keys = 0;
    public Text scoretext;
    private void Start()
    {
        keys = 0;
    }
    public void keysnum()
    {
        scoretext.text = keys.ToString();
    }
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("key"))
        {
            keys += 1;
            keydelete.deleteKey1 = true;
            FindObjectOfType<AudioManager>().Play("keypickup");
            keysnum();
        }
        if (other.CompareTag("key2"))
        {
            keys += 1;
            keydelete2.deleteKey2 = true;
            FindObjectOfType<AudioManager>().Play("keypickup");
            keysnum();
        }
        if (other.CompareTag("key3"))
        {
            keys += 1;
            keydelete3.deleteKey3 = true;
            FindObjectOfType<AudioManager>().Play("keypickup");
            keysnum();
        }
        if (other.CompareTag("loputa"))
        {
            if (keys == 3)
            {
                loputa.loputaon = true;
                FindObjectOfType<AudioManager>().Play("keypickup");
                SceneManager.LoadScene(4);
            }
            
        }
    }

}