using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class AllieSpawnerLife : MonoBehaviour
{

    public GameObject spawnerButton;
    public GameObject enemySpawner;
    public GameObject alliePanel;
    Level1Manager level1;

    public float spawnerLife;

    public void Start()
    {
        level1 = GetComponentInParent<Level1Manager>();
        spawnerLife = 150;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        print(col.gameObject.tag);
        if (col.gameObject.CompareTag("EnemySoldierAttack"))
        {
            spawnerLife -= 5f;
        }
        if (col.gameObject.CompareTag("EnemyLancerAttack"))
        {
            spawnerLife -= 4f;
        }
        if (col.gameObject.CompareTag("EnemyHorsemanAttack"))
        {
            spawnerLife -= 5f;
            print("Tomei dano");
        }
    }

    private void OnDestroy()
    {
        level1.alliesSpawners--;
        Destroy(enemySpawner);
        Destroy(spawnerButton);
    }

    void Update()
    {
        if (spawnerLife < 0)
        {
            Destroy(gameObject);
            alliePanel.SetActive(false);
        }
    }
}
