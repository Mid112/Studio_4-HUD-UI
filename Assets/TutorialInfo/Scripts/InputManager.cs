using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freeLookCamera;
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            input += (Vector3) freeLookCamera.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input -= (Vector3)  freeLookCamera.transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input -= (Vector3)  freeLookCamera.transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input += (Vector3)  freeLookCamera.transform.right;
        }
        OnMove.Invoke(input);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed");
        }

        
    }
}
