using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
    //Spin for the coins
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        
    }
    

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InputManager.Instance.IncreaseScore();
            Destroy(gameObject); // destroys the asteroid
            
        }
    }
}
