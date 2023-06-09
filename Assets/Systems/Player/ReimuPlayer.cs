using System;
using UnityEngine;

public class ReimuPlayer : PlayerBase
{
    public override void SetPlayerProperties()
    {
        base.SetPlayerProperties();
        
        _unfocusedSpeed = 7.0f;
        _focusedSpeed = 3.0f;
    }
    public override void Shoot()
    {
        Debug.Log("Atirando com a Reimu");
    }
    public override void Bomb()
    {
        Debug.Log("Bomb com a Reimu");
    }
    public override void Flashbomb()
    {
        Debug.Log("Flashbomb com a Reimu");
    }
}