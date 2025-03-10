using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.Events;
using TMPro;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;


    [SerializeField] private CinemachineCamera freeLookCamera;
    [SerializeField] private PlayerMove playerMove;
    [SerializeField] private CoinCounterUI coinCounter;
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();
    public UnityEvent OnSpacePressed = new UnityEvent();
    private int score = 0;
    public int jumpForce = 10;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // executing singleton pattern
        if (Instance == null)
        {
            Instance = this;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            input += (Vector3)freeLookCamera.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input -= (Vector3)freeLookCamera.transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input -= (Vector3)freeLookCamera.transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input += (Vector3)freeLookCamera.transform.right;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            input.y = jumpForce;
        }

        OnMove.Invoke(input);

    }

    public void IncreaseScore()
    {
        score++;
        UpdateScoreUI();

    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            coinCounter.UpdateScore(score);
        }
    }

}
