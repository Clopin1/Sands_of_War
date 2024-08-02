using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCooldown3 : MonoBehaviour
{
    public void Update()
    {
        transform.localScale = new Vector2(AlliesSpawn3.putNewSoldier / 4.8f, 0.04166667f);
    }
}
