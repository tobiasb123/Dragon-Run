using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door5ChangeCameraView : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private void Awake()
    {
        cam2.enabled = false;
        cam1.enabled = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            cam2.enabled = true;
            cam1.enabled = false;
        }
    }
}
