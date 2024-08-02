using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region Variables

    public Transform[] EnemyTroopSpawnPoint;

    [Header ("Soldier")]
    public GameObject[] enemySoldierPrefab;
    public float secondsToSoldierAppear;

    [Header("Lancer")]
    public GameObject[] enemyLancerPrefab;
    public float secondsToLancerAppear;

    [Header("Horseman")]
    public GameObject[] enemyHorsemanPrefab;
    public float secondsToHorsemanAppear;

    MoneyScript moneyScript;

    #endregion Variables

    public void Awake()
    {
        Time.timeScale = 1f;
    }

    #region Enemies Spawn

    void SoldierSpawn()
    {

        if (secondsToSoldierAppear >= 7)
        {
            int EnemySoldierSpawner = Random.Range(0, enemySoldierPrefab.Length);
            int SoldierSpawnerPoint = Random.Range(0, EnemyTroopSpawnPoint.Length);

            Instantiate(enemySoldierPrefab[0], EnemyTroopSpawnPoint[SoldierSpawnerPoint].position, transform.rotation);
            secondsToSoldierAppear = 0;
        }
    }

    void LancerSpawn()
    {

        if (secondsToLancerAppear >= 10)
        {
            int EnemyLancerSpawner = Random.Range(0, enemyLancerPrefab.Length);
            int LancerSpawnerPoint = Random.Range(0, EnemyTroopSpawnPoint.Length);

            Instantiate(enemyLancerPrefab[0], EnemyTroopSpawnPoint[LancerSpawnerPoint].position, transform.rotation);
            secondsToLancerAppear = 0;
        }
    }

    void HorsemanSpawn()
    {
        if (secondsToHorsemanAppear >= 16)
        {
            int EnemyHorsemanSpawner = Random.Range(0, enemyHorsemanPrefab.Length);
            int HorsemanSpawnerPoint = Random.Range(0, EnemyTroopSpawnPoint.Length);

            Instantiate(enemyHorsemanPrefab[0], EnemyTroopSpawnPoint[HorsemanSpawnerPoint].position, transform.rotation);
            secondsToHorsemanAppear = 0;
        }
    }

    #endregion Enemies spawn

    void Update()
    {
        secondsToSoldierAppear += Time.deltaTime;
        secondsToLancerAppear += Time.deltaTime;
        secondsToHorsemanAppear += Time.deltaTime;

        SoldierSpawn();

        LancerSpawn();

        HorsemanSpawn();
    }
}
