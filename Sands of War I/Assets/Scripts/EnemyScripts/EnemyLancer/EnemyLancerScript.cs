using System.Collections;
using UnityEngine;

public class EnemyLancerScript : MonoBehaviour
{
    public double lancerHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator enemyLancerAnimator;

    public void Start()
    {
        enemyLancerAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        lancerHealth = 40;
        moveSpeed = -0.8f;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSoldierAttack"))
        {
            lancerHealth -= 5;
        }
        if (collision.gameObject.CompareTag("AllieLancerAttack"))
        {
            lancerHealth -= 4;
        }
        if (collision.gameObject.CompareTag("AllieHorsemanAttack"))
        {
            lancerHealth -= 2.5;
        }
    }

    public void Death()
    {
        Destroy(this.gameObject);
    }

    public void Update()
    {
        if (lancerHealth <= 0)
        {
            Death();
            MoneyScript.money += 15;
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
