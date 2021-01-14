using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class UnitManager : MonoBehaviour
    {
        public static UnitController player, enemy;

        //
        public UnitController _player, _enemy;

        private void Awake()
        {
            player = _player;
            enemy = _enemy;
        }
        //


        //public void SetTargetPlayer(UnitController unit)
        //{
        //    player = unit;
        //}

        //public void SetTargetEnemy(UnitController unit)
        //{
        //    enemy = unit;
        //}

        //public void SetNullTarget()
        //{
        //    player = null;
        //}

        //public void SetNullEnemy()
        //{
        //    enemy = null;
        //}
    }
}