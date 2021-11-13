using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHeadAnimations : MonoBehaviour
{
    private Animator anim;
    private BoxCollider2D boxCollider;
    [SerializeField] private GameObject RockHead;
    [SerializeField] private GameObject Heart;
    public Transform target;
    public float t;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && anim)
        {
                anim.SetTrigger("hit");
        }
    }

    public void HitDone()
    {
        anim.SetTrigger("hitDone");
        Heart.SetActive(true);
        RockHead.SetActive(false);
    }

    public void FixedUpdate()
    {
            Vector3 a = transform.position;
            Vector3 b = target.position;
            Heart.transform.position = Vector3.Lerp(a, b, t);
    }
}
