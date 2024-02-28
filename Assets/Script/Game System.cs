using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject water;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject panelPause;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelPause.activeInHierarchy)
            {
                panelPause.SetActive(false);
                character.gameObject.GetComponent<CharacterControler>().enabled = true;
                water.gameObject.GetComponent<Animator>().enabled = true;
                coin.gameObject.GetComponent<Animator>().enabled = true;
                character.gameObject.GetComponent<Animator>().enabled = true;
            }
            else
            {
                panelPause.SetActive(true);
                character.gameObject.GetComponent<CharacterControler>().enabled = false;
                water.gameObject.GetComponent<Animator>().enabled = false;
                coin.gameObject.GetComponent<Animator>().enabled = false;
                character.gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }
    public void restartGame()
    {
        StopAllCoroutines();
        SceneManager.LoadScene("IN GAME(SUMMER)");
    }
}
