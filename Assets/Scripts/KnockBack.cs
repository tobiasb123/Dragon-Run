using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float knockbackPower;
    private float knockbackCooldown;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        knockbackCooldown = 2;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spikes" && knockbackCooldown >= 2)
        {
            body.velocity = new Vector2(body.velocity.x, knockbackPower);
            knockbackCooldown = 0;
        }

        if (collision.tag == "Saw" && knockbackCooldown >= 2)
        {
            body.velocity = new Vector2(body.velocity.x, knockbackPower);
            knockbackCooldown = 0;
        }
    }

    private void Update()
    {
        knockbackCooldown += Time.deltaTime;
        if (knockbackCooldown > 2)
            knockbackCooldown = 2;
    }
}
