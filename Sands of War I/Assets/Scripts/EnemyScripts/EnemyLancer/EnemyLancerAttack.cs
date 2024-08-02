using System.Collections;
using UnityEngine;

public class EnemyLancerAttack : MonoBehaviour
{
    EnemyLancerScript enemyLancerScript;
    public bool Attacking;

    void Start()
    {
        enemyLancerScript = GetComponentInParent<EnemyLancerScript>();
    }
    void Update()
    {
        if (Attacking)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        enemyLancerScript.enemyLancerAnimator.SetBool("taAtacando", true);
        enemyLancerScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        enemyLancerScript.enemyLancerAnimator.SetBool("taAtacando", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AllieSoldier"))
        {
            Attacking = true;
        }

        if (collision.gameObject.CompareTag("AllieSpawner"))
        {
            Attacking = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("AllieSpawner") || collision.gameObject.CompareTag("AllieSoldier"))
        {
            Attacking = false;
            enemyLancerScript.moveSpeed = -0.8f;
        }
    }
}
