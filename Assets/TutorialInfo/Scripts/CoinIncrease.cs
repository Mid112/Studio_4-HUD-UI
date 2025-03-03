using UnityEngine;

public class CoinIncrease : MonoBehaviour
{
    public int scoreValue = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InputManager.Instance.AddScore(scoreValue);
            Destroy(gameObject); // destroys the asteroid
            
        }
    }
}
