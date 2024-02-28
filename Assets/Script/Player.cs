using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private GameObject coinCounter;
    private int coinCollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.GetComponent<Text>().text = coinCollected.ToString();
    }

    public void addCoinCollected()
    {
        coinCollected = coinCollected + 1;
    }

    public void dead()
    {
        panelGameOver.SetActive(true);
        gameObject.GetComponent<CharacterControler>().enabled = false;
    }
}
