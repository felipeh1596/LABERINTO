using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float pointer_x = Input.GetAxis("Mouse Y");
            float pointer_y = Input.GetAxis("Mouse X");
            transform.Rotate(0, -pointer_y * -1.5f, 0);
            

        }

    }
}