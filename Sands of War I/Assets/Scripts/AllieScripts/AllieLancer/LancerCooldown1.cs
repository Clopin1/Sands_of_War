using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancerCooldown1 : MonoBehaviour
{
    public void Update()
    {
        transform.localScale = new Vector2(AlliesSpawn.putNewLancer / 9.6f, 0.04166667f);
    }
}
