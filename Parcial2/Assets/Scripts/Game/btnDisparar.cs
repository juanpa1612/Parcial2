using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Parcial2.Game
{
    public class btnDisparar : MonoBehaviour
    {
        private void Start()
        {
            FindObjectOfType<Player>().OnFire += PlayerFire;
        }
        public void Disparar ()
        {
            
        }
        public void PlayerFire()
        {
            gameObject.GetComponent<Button>().interactable = false;
            FindObjectOfType<Bullet>().OnBulletDestroy += ResetButton;
        }
        public void ResetButton ()
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }

}

