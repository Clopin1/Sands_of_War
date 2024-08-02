using System.Collections;
using UnityEngine;

public class AllieLancerScript : MonoBehaviour
{
    public double lancerHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator allieLancerAnimator;

    public void Start()
    {
        allieLancerAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        lancerHealth = 40;
        moveSpeed = 0.8f;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySoldierAttack"))
        {
            lancerHealth -= 5;
            Debug.Log("lanceiro: tomei dano do soldado");
        }
        if (collision.gameObject.CompareTag("EnemyLancerAttack"))
        {
            lancerHealth -= 4;
            Debug.Log("lanceiro: tomei dano do lanceiro");
        }
        if (collision.gameObject.CompareTag("EnemyHorsemanAttack"))
        {
            lancerHealth -= 2.5;
            Debug.Log("lanceiro: tomei dano do cavaleiro");
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
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
