using System.Collections;
using UnityEngine;
public class AllieSoldierScript : MonoBehaviour
{
    public double soldierHealth;
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator allieSoldierAnimator;
    
    public void Start()
    {
        allieSoldierAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        soldierHealth = 40;
        moveSpeed = 1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySoldierAttack"))
        {
            soldierHealth -= 2.5;
            Debug.Log("Soldado: tomei dano do soldado");
        }
        if (collision.gameObject.CompareTag("EnemyLancerAttack"))
        {
            soldierHealth -= 2;
            Debug.Log("Soldado: tomei dano do lanceiro");
        }
        if (collision.gameObject.CompareTag("EnemyHorsemanAttack"))
        {
            soldierHealth -= 5;
            Debug.Log("Soldado: tomei dano do cavaleiro");
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
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}