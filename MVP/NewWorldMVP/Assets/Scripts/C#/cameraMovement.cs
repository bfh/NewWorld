using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int speed = 2;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 25)
            { transform.Translate(new Vector3(speed * (-transform.position.z / 10) * Time.deltaTime, 0, 0)); }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > 0)
            { transform.Translate(new Vector3(-speed * (-transform.position.z / 10) * Time.deltaTime, 0, 0)); }

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > 0)
            { transform.Translate(new Vector3(0, -speed * (-transform.position.z / 10) * Time.deltaTime, 0)); }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 10)
            { transform.Translate(new Vector3(0, speed * (-transform.position.z / 10) * Time.deltaTime, 0)); }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (transform.position.z < -2)
            { transform.Translate(new Vector3(0, 0, 2 * Time.deltaTime)); }

        }
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.z > -25)
            { transform.Translate(new Vector3(0, 0, -2 * Time.deltaTime)); }

        }
    }
}
