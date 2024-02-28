using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Mace : MonoBehaviour
{
    public GameObject DialoguePanel;
    public Text DialogueText;
    public string[] dialogue;
    private int index;

    public GameObject ButtonContinue;
    public float WordSpeed;
    public bool playerIsClose;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (DialogueText.text == dialogue[index])
            {
                ButtonContinue.SetActive(true);
            }

            if (DialoguePanel.activeInHierarchy)
            {
                ZeroText();
            }
            else
            {
                DialoguePanel.SetActive(false);
                StartCoroutine(Typing());
            }
        }
    }

    public void ZeroText()
    {
        DialogueText.text = "";
        index = 0;
        DialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(WordSpeed);
        }
    }

    public void NextLine()
    {
         ButtonContinue.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            DialogueText.text ="";
            StartCoroutine(Typing());
        }
        else 
        {
            ZeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            ZeroText();
        }
    }

}
