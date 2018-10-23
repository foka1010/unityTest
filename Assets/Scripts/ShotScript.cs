using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    // 0 - Designer variables

    /// <summary>
    /// Damage inflicted
    /// </summary>
    public int shotLife = 20;
    public int damage = 1;

    /// <summary>
    /// Projectile damage player or enemies?
    /// </summary>
    public bool isEnemyShot = false;

    void Start()
    {
        // 1 - Limited time to live to avoid any leak
        Destroy(gameObject, shotLife); // 20sec
    }
}
