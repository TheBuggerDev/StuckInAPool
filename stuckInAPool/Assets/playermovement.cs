using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    
    public float mouseSensetivity = 100f;
    public Transform PlayerBody;
    public GameObject Player;
    float xRotation = 0f;

    float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        

        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensetivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        yRotation += mouseX;
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0);
        PlayerBody.Rotate(Vector3.up * mouseX + Vector3.right * mouseY);
        
        
       


    }
}
