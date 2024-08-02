using System.Collections;
using UnityEngine;

public class EnemySoldierScript : MonoBehaviour
{
    public double soldierHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator enemySoldierAnimator;

    public void Start()
    {
        enemySoldierAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        soldierHealth = 40;
        moveSpeed = -1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSoldierAttack"))
        {
            soldierHealth -= 2.5;
        }
        if (collision.gameObject.CompareTag("AllieLancerAttack"))
        {
            soldierHealth -= 2;
        }
        if (collision.gameObject.CompareTag("AllieHorsemanAttack"))
        {
            soldierHealth -= 5;
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }

    public void Update()
    {

        if (soldierHealth <= 0)
        {
            Death();
            MoneyScript.money += 15;
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

}

