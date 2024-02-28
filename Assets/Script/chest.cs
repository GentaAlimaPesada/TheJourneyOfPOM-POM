using System.Collections;
using UnityEngine;

public class chest : MonoBehaviour
{
    private bool playerNearChest = false;
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject panelVictory;
    [SerializeField] private GameObject informationText;
    [SerializeField] private float displayTime = 2f; // Waktu tampilan teks setelah pemain menjauh

    private Coroutine displayCoroutine;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ShowInformationText();
            playerNearChest=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HideInformationTextAfterDelay();
            playerNearChest=false; 
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                panelVictory.SetActive(true);
                character.gameObject.GetComponent<CharacterControler>().enabled = false;
                character.gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }

    private void Update()
    {
        if (playerNearChest == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                panelVictory.SetActive(true);
                character.gameObject.GetComponent<CharacterControler>().enabled = false;
                character.gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }

    private void ShowInformationText()
    {
        if (displayCoroutine != null)
        {
            StopCoroutine(displayCoroutine);
        }

        informationText.SetActive(true);
    }

    private void HideInformationTextAfterDelay()
    {
        displayCoroutine = StartCoroutine(HideInformationTextDelayed());
    }

    private IEnumerator HideInformationTextDelayed()
    {
        yield return new WaitForSeconds(displayTime);
        informationText.SetActive(false);
    }
}
