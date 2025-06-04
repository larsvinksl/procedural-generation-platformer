using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogBehaviour : MonoBehaviour
{
    public Transform player; // Assign in the Inspector
    public float minSpeed = 1f; // Minimum movement speed
    public float maxSpeed = 20f; // Maximum movement speed
    public float accelerationFactor = 0.5f; // Adjusts acceleration scaling

    public Transform DeletePoint;

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);
            float speed = Mathf.Clamp(Mathf.Pow(distance * accelerationFactor, 2), minSpeed, maxSpeed);

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}


