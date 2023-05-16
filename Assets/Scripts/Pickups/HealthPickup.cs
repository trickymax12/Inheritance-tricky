using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    public float healValue;
    public override void Activate()
    {
        Player.health += healValue;
        if(Player.health > Player.maxHealth)
        {
            Player.health = Player.maxHealth;
        }
    }
}
