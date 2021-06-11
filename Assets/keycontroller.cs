using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
         Rigidbody rb = GetComponent<Rigidbody>();
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left*3f);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right*3f);
         if (Input.GetKey(KeyCode.W))
             // rb.AddForce(Vector3.up);
             rb.AddForce(Vector3.forward*3f);
             //transform.Translate(new Vector3(0f,0f,4f)*Time.deltaTime); // ileri giderken
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.back*3);
            //transform.Translate(Vector3.back*4f*Time.deltaTime); // geri giderken
            //transform.Translate(new Vector3(0f,0f,-4f)*Time.deltaTime);
            
        
    }
}
