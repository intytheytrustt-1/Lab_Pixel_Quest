using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    string varOne = "Hello World";
    int counter = 0;
    void Start()
    {
        string varTwo = "World";
        Debug.Log(varOne + varTwo); 
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
      

         counter = counter + 1;
        Debug.Log(counter);
    }
    
}
