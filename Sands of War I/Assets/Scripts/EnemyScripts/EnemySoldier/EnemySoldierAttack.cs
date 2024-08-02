using System.Collections;
using UnityEngine;

public class EnemySoldierAttack : MonoBehaviour
{
    EnemySoldierScript enemySoldierScript;
    public bool attacking;

    void Start()
    {
        enemySoldierScript = GetComponentInParent<EnemySoldierScript>();
    }

    void Update()
    {
        if (attacking == true)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        enemySoldierScript.enemySoldierAnimator.SetBool("taAtacando", true);
        enemySoldierScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        enemySoldierScript.enemySoldierAnimator.SetBool("taAtacando", false);
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
            enemySoldierScript.moveSpeed = -1;
        }
    }
}
