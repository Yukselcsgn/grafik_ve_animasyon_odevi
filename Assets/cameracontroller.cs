using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))

            transform.Translate(new Vector3(-3.5f,0f,0f)*Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(3.5f,0f,0f)*Time.deltaTime);;
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0f,0f,3.5f)*Time.deltaTime); // ileri giderken
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back*3.5f*Time.deltaTime); // geri giderken   
    }
}
