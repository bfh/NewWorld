using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Camera cam;


    // Use this for initialization
    void Start()
    { GameObject controller = GameObject.FindGameObjectWithTag("GameController");
         cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject controller = GameObject.FindGameObjectWithTag("GameController");
        double camX = controller.GetComponent<HexGrid>().x * 0.88;
        double camY = controller.GetComponent<HexGrid>().y * 0.76210233333;

        int speed = 2;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < camX)
            {
            
                transform.Translate(new Vector3(speed * (cam.orthographicSize / 2) * Time.deltaTime, 0, 0)); }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > 0)
            { transform.Translate(new Vector3(-speed * (cam.orthographicSize / 2) * Time.deltaTime, 0, 0)); }

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > 0)
            { transform.Translate(new Vector3(0, -speed * (cam.orthographicSize / 2) * Time.deltaTime, 0)); }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < camY)
            { transform.Translate(new Vector3(0, speed * (cam.orthographicSize / 2) * Time.deltaTime, 0)); }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (cam.orthographicSize > 1)
            {
                cam.orthographicSize -= 0.1f;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (cam.orthographicSize < 18 )
            {
                cam.orthographicSize += 0.1f;
            }

        }
    }
}
