using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerholder : MonoBehaviour
{
    public static playerholder instance;
    public BoxCollider2D boxCollider1;
    public BoxCollider2D boxCollider2;
    public BoxCollider2D boxCollider3;
    [SerializeField] private int countdownTime;


    private void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        while (countdownTime > 0)
        {

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        boxCollider1.enabled = false;
        boxCollider2.enabled = false;
        boxCollider3.enabled = false;
    }
}