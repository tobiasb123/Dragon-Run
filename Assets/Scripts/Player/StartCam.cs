using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCam : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private void Awake()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
}
