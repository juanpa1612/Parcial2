using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Parcial2.Game
{
    public class FactoryMedEnemy : MonoBehaviour
    {
        [SerializeField]
        private Vector3 pos1;
        [SerializeField]
        private Enemy enemyC;


        public Enemy InstantiateEnemy()
        {
            Enemy enemy;
            enemy = GameObject.Instantiate(enemyC, pos1, Quaternion.identity);
            return enemy;
        }
    }
}


