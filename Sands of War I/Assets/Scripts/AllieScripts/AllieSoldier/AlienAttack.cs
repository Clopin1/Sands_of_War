using System.Collections;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    AllieSoldierScript allieSoldierScript;
    public bool Attacking;

    void Start()
    {
        allieSoldierScript = GetComponentInParent<AllieSoldierScript>();
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
        allieSoldierScript.allieSoldierAnimator.SetBool("taAtacando", true);
        allieSoldierScript.moveSpeed = 0;

        yield return new WaitForSeconds(0.35f);
        allieSoldierScript.allieSoldierAnimator.SetBool("taAtacando", false);
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
            allieSoldierScript.moveSpeed = 1;
        }
    }
}
