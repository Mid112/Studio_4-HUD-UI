using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private GroundTrigger groundTrigger;
    private Rigidbody rb;
    public bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = groundTrigger.isGrounded;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    void MovePlayer(Vector3 input)
    {
        Vector3 moveDirection = input;
        
        rb.AddForce(moveDirection * speed);
        
    }

}