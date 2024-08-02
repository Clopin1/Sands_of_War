using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorsemanCooldown1 : MonoBehaviour
{
    public void Update()
    {
        transform.localScale = new Vector2(AlliesSpawn.putNewHorseman / 15.7f, 0.04166667f);
    }
}
