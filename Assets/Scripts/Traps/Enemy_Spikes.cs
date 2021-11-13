using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spikes : MonoBehaviour
{
    [SerializeField] private float damage;
    private float attackCooldown;

    private void Awake()
    {
        attackCooldown = 2;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && attackCooldown >= 2)
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            attackCooldown = 0;
        }
    }

    private void Update()
    {
        attackCooldown += Time.deltaTime;
        if (attackCooldown > 2) attackCooldown = 2;
    }
}
