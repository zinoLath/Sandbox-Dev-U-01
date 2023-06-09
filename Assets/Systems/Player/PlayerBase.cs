using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerActions 
{
    void Shoot();
    void Bomb();
    void Flashbomb();

}

public class PlayerBase : MonoBehaviour, IPlayerActions
{
    protected float _unfocusedSpeed;
    protected float _focusedSpeed;
    protected float _speed;
    public int life = 6;
    private Vector2 _inputVec;
    public bool canShoot;
    public bool canBomb;
    public bool canFlashbomb;

    private void Awake()
    {
        GameManager.onPlayerDeath += OnPlayerDeath;
    }

    void Start()
    {
        SetPlayerProperties();
    }

    void Update()
    {
        _inputVec = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        if (Input.GetButton("Shoot"))
        {
            HandleShoot();
        }
        if (Input.GetButton("Bomb"))
        {
            HandleBomb();
        }
        if (Input.GetButton("Flashbomb"))
        {
            HandleFlashbomb();
        }

        _speed = _unfocusedSpeed;
        if (Input.GetButton("Focus"))
        {
            _speed = _focusedSpeed;
        }
    }

    void FixedUpdate()
    {
        Move(_inputVec);
    }

    public virtual void SetPlayerProperties()
    {
        _unfocusedSpeed = 2.0f;
        _focusedSpeed = 1.0f;
        canShoot = true;
        canBomb = true;
        canFlashbomb = true;
    }

    public virtual void Move(Vector2 input) //caso algum player tenha um movimento especial, como uma gravidade ou algo assim
    {
        input = Vector2.ClampMagnitude(input, 1) * _speed * Time.fixedDeltaTime;
        transform.position += new Vector3(input.x, input.y,0);
    }

    private void HandleShoot()
    {
        if(canShoot)
        {
            this.Shoot();
            if(transform.childCount == 0) return;
            for (int i = 0; i < transform.childCount; i++)
            {
                IPlayerActions childActions = transform.GetChild(i).GetComponent(typeof(IPlayerActions)) as IPlayerActions;
                childActions.Shoot();
            }
        }
    }
    public virtual void Shoot()
    {
        
    }
    private void HandleBomb()
    {
        if(canBomb)
        {
            this.Bomb();
            if(transform.childCount == 0) return;
            for (int i = 0; i < transform.childCount; i++)
            {
                IPlayerActions childActions = transform.GetChild(i).GetComponent(typeof(IPlayerActions)) as IPlayerActions;
                childActions.Bomb();
            }
        }
    }
    public virtual void Bomb()
    {
        
    }
    private void HandleFlashbomb()
    {
        if(canFlashbomb)
        {
            this.Flashbomb();
            if(transform.childCount == 0) return;
            for (int i = 0; i < transform.childCount; i++)
            {
                IPlayerActions childActions = transform.GetChild(i).GetComponent(typeof(IPlayerActions)) as IPlayerActions;
                childActions.Flashbomb();
            }
        }
    }
    public virtual void Flashbomb()
    {
        
    }

    private void OnPlayerDeath()
    {
        life--;
    }
}
