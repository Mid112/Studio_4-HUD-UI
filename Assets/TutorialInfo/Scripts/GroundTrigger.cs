using UnityEngine;
using System;
using UnityEngine.Events;
public class GroundTrigger : MonoBehaviour
{
    
    [SerializeField] private PlayerMove playerMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerMove.isGrounded = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (playerMove.isGrounded)
        {
            playerMove.isGrounded = false;
        }
    }
}
