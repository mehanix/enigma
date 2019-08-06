using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject textGO, gameManager;
    public bool isCorrect;
    public string text;
    private bool ans=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(ans==false) {
            ans=true;
 this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("bop");
        text=text.Replace("\\n","\n");

        textGO.GetComponent<TextMesh>().text = text;
        if(isCorrect == false)
            gameManager.GetComponent<GameManager>().loseHp();

        Destroy(this.transform.parent.gameObject);
        }
       
       
    }
}
