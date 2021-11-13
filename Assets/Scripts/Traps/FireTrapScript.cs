using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrapScript : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private float damage;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider.enabled = false;
    }

    public void turnOn()
    {
        anim.SetTrigger("turnOn");
    }

    private void fireOn()
    {
        anim.SetTrigger("fireOn");
        boxCollider.enabled = true;
    }

    private void turnOff()
    {
        anim.SetTrigger("turnOff");
        boxCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && boxCollider.enabled == true)
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
