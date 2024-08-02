using System.Collections;
using UnityEngine;

public class AllieHorsemanScript : MonoBehaviour
{
    public double horsemanHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator allieHorsemanAnimator;

    public void Start()
    {
        allieHorsemanAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        horsemanHealth = 50;
        moveSpeed = 1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySoldierAttack"))
        {
            horsemanHealth -= 2.5;
        }
        if (collision.gameObject.CompareTag("EnemyLancerAttack"))
        {
            horsemanHealth -= 6;
        }
        if (collision.gameObject.CompareTag("EnemyHorsemanAttack"))
        {
            horsemanHealth -= 3;
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }

    public void Update()
    {
        if (horsemanHealth <= 0)
        {
            Death();
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
