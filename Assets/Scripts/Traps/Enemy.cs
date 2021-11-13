using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float damage;
    private float attackCooldown;
    public ParticleSystem dieParticles;
    public ParticleSystem dieParticles2;
    private int hit;
    public BoxCollider2D boxCollider;
    public BoxCollider2D boxCollider2;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        dieParticles.Stop();
        dieParticles2.Stop();
        hit = 0;
        attackCooldown = 2;
        boxCollider.enabled = true;
        boxCollider2.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Fireball")
        {
            hit += 1;
            dieParticles.Play();
            dieParticles2.Play();

            if (hit >= 3)
            {
                anim.SetTrigger("die");
                boxCollider.enabled = false;
                boxCollider2.enabled = false;
            }
        }

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

    private void die()
    {
        enemy.SetActive(false);
    }
}
