using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ZinoLIB.UI
{
    [ExecuteInEditMode]
    public class HUDIcon : MonoBehaviour
    {
        public Image fillImage;
        public float value;
        void Start()
        {
        }

        void Update()
        {
            fillImage.fillAmount = value;
        }
    }
}