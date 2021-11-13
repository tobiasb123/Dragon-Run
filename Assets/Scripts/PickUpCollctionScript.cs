using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpCollctionScript : MonoBehaviour
{
    [SerializeField] private GameObject Melon;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            anim.SetTrigger("collected");
        }
    }

    public void Destroy()
    {
        Melon.SetActive(false);
    }
}
