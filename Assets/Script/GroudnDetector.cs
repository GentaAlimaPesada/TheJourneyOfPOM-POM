using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject character;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {
             character.GetComponent<CharacterControler>().setIsGrounded(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            character.GetComponent<CharacterControler>().setIsGrounded(false);
        }
    }
}
