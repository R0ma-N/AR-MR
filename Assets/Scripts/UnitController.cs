using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class UnitController : MonoBehaviour
    {
        [SerializeField] protected Combat combat;
        [SerializeField] protected float FightDistance = 0.3f;

        public UnityEvent OnDie;

        public Health health;

        protected bool isDead;

        protected virtual void Update()
        {
            if (health != null && health.curHealth <= 0 && !isDead)
            {
                Die();
            }
        }

        public virtual void Die()
        {
            isDead = true;
        }
    }
}
