using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;

    void Start()
    {
        
    }

   
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, rotateSpeed * moveX* Time.deltaTime,0f);
        }
    }
}
