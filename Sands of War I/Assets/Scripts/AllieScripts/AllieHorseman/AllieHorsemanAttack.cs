using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllieHorsemanAttack : MonoBehaviour
{
    AllieHorsemanScript allieHorsemanScript;
    public bool Attacking;

    void Start()
    {
        allieHorsemanScript = GetComponentInParent<AllieHorsemanScript>();
    }
    void Update()
    {
        if (Attacking == true)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        allieHorsemanScript.allieHorsemanAnimator.SetBool("TaAtacando", true);
        allieHorsemanScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        allieHorsemanScript.allieHorsemanAnimator.SetBool("TaAtacando", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySoldier"))
        {
            Attacking = true;
        }

        if (collision.gameObject.CompareTag("EnemySpawner"))
        {
            Attacking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemySpawner") || collision.gameObject.CompareTag("EnemySoldier"))
        {
            Attacking = false;
            allieHorsemanScript.moveSpeed = 1;
        }
    }
}
