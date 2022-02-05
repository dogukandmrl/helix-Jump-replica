using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;
    private float move_X;
    void Update()
    {
        move_X = Input.GetAxis("Mouse X");
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0f, move_X * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
