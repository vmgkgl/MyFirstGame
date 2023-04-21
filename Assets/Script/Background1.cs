using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background1 : MonoBehaviour
{
    public Transform target;
    public float ScrollAmount;
    public float moveSpeed;
    public Vector3 moveDirection;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * 0.1f *Time.deltaTime;
        if (transform.position.x <= -ScrollAmount)
        {
            transform.position = target.position - moveDirection * ScrollAmount;
        }
    }
}
