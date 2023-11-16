using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityUserScript : MonoBehaviour
{

    public Ability boostAbility;
    float boostCooldownTime;
    float boostActiveTime;
    public GameObject parent;

    enum AbilityState
    {
        active,
        cooldown,
        useable
    }

    AbilityState boostState = AbilityState.useable;

    public KeyCode boostButton;
    
    // Update is called once per frame
    void Update()
    {
        switch (boostState)
        {
            case AbilityState.active:
                if (boostActiveTime > 0) 
                {
                    boostActiveTime -= Time.deltaTime; 
                } else {
                    boostState = AbilityState.cooldown;
                    boostCooldownTime = boostAbility.cooldownTime;
                } 
                break;

            case AbilityState.cooldown:
                if(boostCooldownTime > 0)
                {
                    boostCooldownTime -= Time.deltaTime;
                } else {
                    boostState = AbilityState.useable;
                }
                break;

            case AbilityState.useable:
                if (Input.GetKeyDown(boostButton))
                {
                    boostState = AbilityState.active;
                    boostActiveTime = boostAbility.activeTime;
                    boostAbility.ActivateAbility(parent);
                }
                break;
        }
        
    }
}
