using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Pickup
{
    public float speedValue;
    public override void Activate()
    {
        Player.moveSpeed += speedValue;
        if(Player.moveSpeed > Player.maxSpeed)
        {
            Player.moveSpeed = Player.maxSpeed;
        }
    }
}
