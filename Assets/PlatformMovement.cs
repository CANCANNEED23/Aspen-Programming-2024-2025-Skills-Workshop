using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    // Set the variables for the platform movement
    public float speed = 2.0f;  // Speed of platform movement
    public float distance = 5.0f;  // Distance the platform moves

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector3(move, 0, 0);
    }
}
