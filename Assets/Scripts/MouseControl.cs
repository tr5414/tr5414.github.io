using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    Renderer Sharpen;

    // Start is called before the first frame update
    void Start()
    {
        Sharpen = GetComponent<Renderer>();
        Sharpen.material.shader = Shader.Find("Custom/Sharpen");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Sharpen.material.shader = Shader.Find("Custom/Sharpen");

        }
        Sharpen.material.SetFloat("_LookUpDistance", Input.mousePosition.x / 100);
     

    }

}