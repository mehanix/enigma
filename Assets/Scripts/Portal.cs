﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject textGO, gameManager;
    public bool isCorrect;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        textGO.GetComponent<TextMesh>().text = text;
        if(isCorrect == false)
            gameManager.GetComponent<GameManager>().loseHp();

        Destroy(this.transform.parent.gameObject);
       
    }
}