using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geocontroller : MonoBehaviour

{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextlevel = "Level2";
    // Start is called before the first frame update
    string varOne = "Hello World";
    int counter = 0;
    void Start()

    {
        string varTwo = "World";
        Debug.Log(varOne + varTwo);
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    private void Update()

    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        //Debug.Log(xInput);
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
            if(Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-1, 0, 0); 
        
        }
            if(Input.GetKeyDown(KeyCode.D))
        { transform.position += new Vector3(1, 0, 0); }

            counter = counter + 1;
        Debug.Log(counter);
        */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);

                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }
        }

    }
}
  
       

        
    

