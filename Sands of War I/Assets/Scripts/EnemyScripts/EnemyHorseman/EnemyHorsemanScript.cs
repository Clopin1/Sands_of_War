using System.Collections;
using UnityEngine;

public class EnemyHorsemanScript : MonoBehaviour
{
    public double horsemanHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator enemyHorsemanAnimator;

    public void Start()
    {
        enemyHorsemanAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        horsemanHealth = 50;
        moveSpeed = -1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSoldierAttack"))
        {
            horsemanHealth -= 2.5;
        }
        if (collision.gameObject.CompareTag("AllieLancerAttack"))
        {
            horsemanHealth -= 6;
        }
        if (collision.gameObject.CompareTag("AllieHorsemanAttack"))
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
            MoneyScript.money += 15;
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
