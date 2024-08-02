using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCooldown : MonoBehaviour
{
    public void Update()
    {
        transform.localScale = new Vector2(AlliesSpawn.putNewSoldier / 4.8f, 0.04166667f);
    }
}
