using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    void OnTriggerEnter2D(Collider2D other) 
    { 
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().addCoinCollected();
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
