using System;
using UnityEngine;

public class SanaePlayer : PlayerBase
{
    public override void SetPlayerProperties()
    {
        base.SetPlayerProperties();
        
        _unfocusedSpeed = 10.0f;
        _focusedSpeed = 5.0f;
    }

    public override void Shoot()
    {
        Debug.Log("Atirando com a Sanae");
    }
    public override void Bomb()
    {
        Debug.Log("Bomb com a Sanae");
    }
    public override void Flashbomb()
    {
        Debug.Log("Flashbomb com a Sanae");
    }
}