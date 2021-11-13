using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDoor : MonoBehaviour
{
    public GameObject FinishScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FinishScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
