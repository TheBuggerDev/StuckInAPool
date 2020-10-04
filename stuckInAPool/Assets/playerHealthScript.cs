using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealthScript : MonoBehaviour
{
    public float life = 5;
    
    public int scene = 0;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("crab"))
        {
            FindObjectOfType<AudioManager>().Play("dead");
            Die();
        }
    }



    void Die()
    {
        
        SceneManager.LoadScene(5);
        
    }
}
