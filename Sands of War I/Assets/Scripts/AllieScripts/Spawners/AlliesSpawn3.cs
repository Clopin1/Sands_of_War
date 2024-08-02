using UnityEngine;

public class AlliesSpawn3 : MonoBehaviour
{

    #region Variables
    [Header("Soldier")]
    public Transform[] AllieSoldierSpawnPoint;
    public GameObject[] AllieSoldierPrefab;
    public static float putNewSoldier = 4.00f;

    [Header("Lancer")]
    public Transform[] allieLancerSpawnPoint;
    public GameObject[] allieLancerPrefab;
    public static float putNewLancer = 8.00f;

    [Header("Horseman")]
    public Transform[] allieHorsemanSpawnPoint;
    public GameObject[] allieHorsemanPrefab;
    public static float putNewHorseman = 13.00f;

    #endregion Variables

    public void Timers()
    {
        putNewSoldier += Time.deltaTime;
        putNewLancer += Time.deltaTime;
        putNewHorseman += Time.deltaTime;

        if (putNewSoldier >= 4.00f)
        {
            putNewSoldier = 4.00f;
        }
        if (putNewLancer >= 8.00f)
        {
            putNewLancer = 8.00f;
        }
        if (putNewHorseman >= 13.00f)
        {
            putNewHorseman = 13.00f;
        }
    }

    #region Spawners

    public void SpawnSoldierButtonOnTrigger()
    {
        if (MoneyScript.money >= 10 && putNewSoldier == 4.00f)
        {
            MoneyScript.money = MoneyScript.money - 10;
            int AllieSoldierSpawner = Random.Range(0, AllieSoldierPrefab.Length);
            int SoldierSpawnerPoint = Random.Range(0, AllieSoldierSpawnPoint.Length);

            Instantiate(AllieSoldierPrefab[0], AllieSoldierSpawnPoint[SoldierSpawnerPoint].position, transform.rotation);

            putNewSoldier = 0;
        }
    }

    public void SpawnLancerOnTrigger()
    {
        if (MoneyScript.money >= 15 && putNewLancer == 8.00f)
        {
            MoneyScript.money = MoneyScript.money - 15;
            int AllieLancerSpawner = Random.Range(0, allieLancerPrefab.Length);
            int LancerSpawnerPoint = Random.Range(0, allieLancerSpawnPoint.Length);

            Instantiate(allieLancerPrefab[0], allieLancerSpawnPoint[LancerSpawnerPoint].position, transform.rotation);

            putNewLancer = 0;
        }
    }

    public void SpawnHorsemanOnTrigger()
    {
        if (MoneyScript.money >= 25 && putNewHorseman == 13.00f)
        {
            MoneyScript.money = MoneyScript.money - 25;
            int AllieHorsemanSpawner = Random.Range(0, allieHorsemanPrefab.Length);
            int HorsemanSpawnerPoint = Random.Range(0, allieHorsemanSpawnPoint.Length);

            Instantiate(allieHorsemanPrefab[0], allieHorsemanSpawnPoint[HorsemanSpawnerPoint].position, transform.rotation);

            putNewHorseman = 0;
        }
    }

    #endregion Spawners

    public void Update()
    {
        Timers();
    }
}
