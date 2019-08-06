using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerQuestion : MonoBehaviour,  IPointerDownHandler
{
    public bool isCorrect;
    public GameManager gameManager;
    public TextMesh wallText;
    public string text;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void OnPointerDown(PointerEventData eventData) {
        wallText.GetComponent<TextMesh>().text = text;

        if (isCorrect == false)
            gameManager.GetComponent<GameManager>().loseHp();
            else
            Destroy(wall);


        Destroy(wall);
        this.transform.parent.gameObject.SetActive(false);


    }
}
