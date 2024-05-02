using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    public Vector3 worldMovementDirection = Vector3.right;
    public float distance = 1f;
    public float speed = 2f;
    Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position; 
    }

    private void Update()
    {
        transform.position = startPosition + (worldMovementDirection * distance * Mathf.Sin(Time.time * speed));
    }

}
