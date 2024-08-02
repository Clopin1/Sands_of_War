using System.Collections;
using UnityEngine;

public class AllieLancerAttack : MonoBehaviour
{
    AllieLancerScript allieLancerScript;
    public bool Attacking;

    void Start()
    {
        allieLancerScript = GetComponentInParent<AllieLancerScript>();
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
        allieLancerScript.allieLancerAnimator.SetBool("TaAtacando", true);
        allieLancerScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        allieLancerScript.allieLancerAnimator.SetBool("TaAtacando", false);
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
        if (collision.gameObject.CompareTag("EnemySoldier") || collision.gameObject.CompareTag("EnemySpawner"))
        {
            Attacking = false;
            allieLancerScript.moveSpeed = 0.8f;
        }
    }
}
