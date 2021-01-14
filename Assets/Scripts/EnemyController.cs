using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class EnemyController : UnitController
    {
        protected override void Update()
        {
            base.Update();
            if (!isDead)// && UnitManager.player.health != null)
            {
                transform.LookAt(UnitManager.player.transform);
                float dist = Vector3.Distance(transform.position, UnitManager.player.transform.position);
                if (dist <= FightDistance)
                {
                    combat.Attack(UnitManager.player.health);
                }
            }
        }

        public override void Die()
        {
            base.Die();
            OnDie.Invoke();
            UnitManager.enemy = null;
        }
    }
}