using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{


    [SerializeField] [Range(0.0f, 10.0f)] float horizontalSpeed = 2.0f;
    [SerializeField] [Range(0.0f, 10.0f)] float verticalSpeed = 2.0f;

    Vector3 lastRot;
    Vector3 lastPos;

    void Update()
    {
        if (Input.GetMouseButton(1))
        {

            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            if (transform.position.y > 0)
            {
                if (transform.eulerAngles.y < 90 || transform.eulerAngles.y > 270)
                {
                    v *= -1;
                }
                lastRot = transform.eulerAngles;
                lastPos = transform.position;
                transform.RotateAround(new Vector3(0, 0, 0), new Vector3(1, 0, 0), v);
                transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), h);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
            }
            else
            {
                transform.eulerAngles = lastRot;
                transform.position = lastPos;
            }
        }
    }

}
