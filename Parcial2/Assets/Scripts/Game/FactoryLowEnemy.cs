using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Parcial2.Game
{
    public class FactoryLowEnemy : MonoBehaviour
    {
        [SerializeField]
        private Vector3 pos1;
        [SerializeField]
        private Enemy enemyD;

        public Enemy InstantiateEnemy ()
        {
            Enemy enemy;
            enemy = GameObject.Instantiate(enemyD, pos1, Quaternion.identity);
            return enemy;
        }
    }
}


