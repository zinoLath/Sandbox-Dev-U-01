using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static UnityAction onPlayerDeath;

    public int score = 0;

    public int lifeCount = 3;
    
    // Start is called before the first frame update
    void Awake()
    {
        GameManager.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
