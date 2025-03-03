using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Spin for the coins
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        
    }
    public int scoreValue = 10;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InputManager.Instance.AddScore(scoreValue);
            Destroy(gameObject); // destroys the asteroid
            
        }
    }
}
