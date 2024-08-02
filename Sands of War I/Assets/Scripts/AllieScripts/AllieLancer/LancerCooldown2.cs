using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancerCooldown2 : MonoBehaviour
{
    public void Update()
    {
        transform.localScale = new Vector2(AlliesSpawn2.putNewLancer / 9.6f, 0.04166667f);
    }
}
