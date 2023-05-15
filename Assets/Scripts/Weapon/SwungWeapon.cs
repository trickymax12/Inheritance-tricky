using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    public float SwingSpeed;
    public float SwingDegrees;

    public override void Attack()
    {
        transform.localEulerAngles = new Vector3(0, 0, -SwingDegrees);
        EnableWeapon();

        StartCoroutine(swing());

    }
    IEnumerator swing()
    {
        float degrees = 0;
        while (degrees < SwingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, SwingSpeed * Time.deltaTime);
            degrees += SwingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        DisableWeapon();
    }

}
