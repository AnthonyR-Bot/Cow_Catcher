using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject
{
    public new string name;

    //cooldown and active time are how long the ability takes to go off cooldown and how long the ability is in effect for respectively
    public float cooldownTime;
    public float activeTime;
    // Update is called once per frame

    public virtual void ActivateAbility(GameObject parent) {}

}
