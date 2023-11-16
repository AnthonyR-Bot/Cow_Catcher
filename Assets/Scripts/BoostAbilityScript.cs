using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoostAbilityScript : Ability
{
    /*
     * How boost ability will work:
     * 1. When ability is used set velocity to boostVelocity repetitively until the active time is 0
     * 2. After that's done stop setting the velocity so it naturally drops back to the maxVelocity
     */

    public float boostVelocity;
    

    public override void ActivateAbility(GameObject parent)
    {
        parent.GetComponent<CarScript>().velocity = boostVelocity;
    }

}
