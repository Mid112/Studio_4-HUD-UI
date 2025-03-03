using UnityEngine;
using System;
using UnityEngine.Events;
public class GroundTrigger : MonoBehaviour
{
    
    [SerializeField] private PlayerMove playerMove;
    public bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isGrounded)
        {
            isGrounded = false;
        }
    }
}
