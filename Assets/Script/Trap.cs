using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            collisionInfo.gameObject.GetComponent<Player>().dead();
            audioSource.Play();
        }
    }
}
