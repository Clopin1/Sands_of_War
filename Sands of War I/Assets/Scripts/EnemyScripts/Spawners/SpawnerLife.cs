using System.Collections;
using UnityEngine;

public class SpawnerLife : MonoBehaviour
{

    public GameObject enemySpawner;
    public GameObject opostSpawner;
    Level1Manager level1;

    public float spawnerLife;

    public void Start()
    {
        level1 = GetComponentInParent<Level1Manager>();
        spawnerLife = 150;
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("AllieSoldierAttack"))
        {
            spawnerLife -= 5;
        }
        if (col.gameObject.CompareTag("AllieLancerAttack"))
        {
            spawnerLife -= 2.5f;
        }
        if (col.gameObject.CompareTag("AllieHorsemanAttack"))
        {
            spawnerLife -= 3.5f;
        }
    }

    void Update()
    {
        if (spawnerLife < 0) 
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        MoneyScript.money += 30;
        level1.enemiesSpawners--;
    }
}
