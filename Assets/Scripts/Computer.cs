using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public GameObject screen;
  

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnMouseDown()
    {
        screen.SetActive(true);
    }
}
