using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFamiliar : MonoBehaviour, IPlayerActions
{
    [SerializeField]
    private float anim_speed;
    private float anim_point = 0f;
    private float radius = 2f;

    // Update is called once per frame
    void Update()
    {
        anim_point += anim_speed * Time.deltaTime;
        transform.localPosition = new Vector3(Mathf.Cos(anim_point), Mathf.Sin(anim_point * 2f),0f) * radius;
    }

    public void Shoot()
    {
        Debug.Log("Familiar está atirando");
    }

    public void Bomb()
    {

    }

    public void Flashbomb()
    {
        
    }
}
