using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace ZinoLIB.UI
{
    public class HUDIconManager : MonoBehaviour
    {
        public HUDIcon iconPrefab;
        public float value;
        [Range(0,10)]
        public int count;
        public List<HUDIcon> objList;
        public PlayerBase player;
        private void Awake()
        {
            GameManager.onPlayerDeath += OnPlayerDeath;
            value = player.life;
        }
        void Start()
        {
            if (objList != null && objList.Count > 0)
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    Destroy(objList[i]);
                }
                
            }
            objList = new List<HUDIcon>(count);
            for (int i = 0; i < count; i++)
            {
                objList.Add(GameObject.Instantiate(iconPrefab, transform));
            }
        }

        void Update()
        {
            
            for (int i = 0; i < objList.Count; i++)
            {
                objList[i].value = Mathf.Clamp(value-i,0,1);
            }
        }

        void OnPlayerDeath()
        {
            value = player.life;
        }
    }

}