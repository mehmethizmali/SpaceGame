using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{

    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    Animator gameAnimate;
    Rigitbody rigitbody;

    // Start is called before the first frame update
    void Start()
    {
        gameAnimate = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        // jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameAnimate.Play("jump", -1, 0f);
        }

        // run
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameAnimate.Play("run",  1, 0f);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            gameAnimate.Play("stop", -1, 0f);
        }



    }

  
}
