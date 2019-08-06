using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int playerHp = 3;
    public GameObject label;
    public GameObject gameOver;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseHp() {
        playerHp--;
        if(playerHp==1)
        label.GetComponent<Text>().text = playerHp + " Greseala ramasa";
        else
        label.GetComponent<Text>().text = playerHp + " Greseli ramase";
        if (playerHp == 0) {
            gameOver.SetActive(true);
            player.SetActive(false);

        }
    }

    public void reset() {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
