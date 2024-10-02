using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformMovement  : MonoBehaviour
{   
    private Transform platform;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = collision.transform;
            transform.SetParent(platform);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.SetParent(null);
        }
    }
}
