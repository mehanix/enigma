using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform laserHit;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.up);
        laserHit.position = hit.point;
        lineRenderer.SetPosition(0,transform.position);
        lineRenderer.SetPosition(1, laserHit.position);
        lineRenderer.enabled = true;
    }
}
