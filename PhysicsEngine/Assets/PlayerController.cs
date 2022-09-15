using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //pretending that we're not in Unity
    private Vector3 position;
    private Vector3 velocity;
    public float acceleration = 1;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        position.x = 0.0f;
        position.y = 0.0f;
        position.z = 0.0f;

        velocity.x = 0.0f;
        velocity.y = 0.0f;
        velocity.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //managers don't directly access keys
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //transform.position += Vector3.forward * speed * Time.deltaTime;
            velocity += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back * speed * Time.deltaTime);
            //transform.position += Vector3.back * speed * Time.deltaTime;
            velocity += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            //transform.position += Vector3.left * speed * Time.deltaTime;
            velocity += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector3.right * speed * Time.deltaTime);
            //transform.position += Vector3.right * speed * Time.deltaTime;
            velocity += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = velocity * acceleration;
        }
        else
        {
            transform.position += velocity * acceleration;
        }
        
        



    }
}
