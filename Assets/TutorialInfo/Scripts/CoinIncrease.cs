using UnityEngine;

public class CoinIncrease : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InputManager.Instance.IncreaseScore();
            Destroy(gameObject); // destroys the asteroid
            
        }
    }
}
