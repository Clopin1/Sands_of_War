using System.Collections;
using UnityEngine;

public class EnemyHosemanAttack : MonoBehaviour
{
    EnemyHorsemanScript enemyHorsemanScript;
    public bool attacking;

    void Start()
    {
        enemyHorsemanScript = GetComponentInParent<EnemyHorsemanScript>();
    }

    void Update()
    {
        if (attacking)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        enemyHorsemanScript.enemyHorsemanAnimator.SetBool("taAtacando", true);
        enemyHorsemanScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        enemyHorsemanScript.enemyHorsemanAnimator.SetBool("taAtacando", false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSoldier"))
        {
            attacking = true;
        }
        if (collision.gameObject.CompareTag("AllieSpawner"))
        {
            attacking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSpawner") || collision.gameObject.CompareTag("AllieSoldier"))
        {
            attacking = false;
            enemyHorsemanScript.moveSpeed = -1;
        }
    }
}
