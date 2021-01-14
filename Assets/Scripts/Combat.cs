using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Assets.Scripts
{
    public class Combat : MonoBehaviour
    {
        [SerializeField] int damage;
        [SerializeField] float cooldown = 2;

        float cooldownTimer;

        public UnityEvent OnAttack;

        void Update()
        {
            if (cooldownTimer > 0)
            {
                cooldownTimer -= Time.deltaTime;
            }
        }

        public void Attack(Health health)
        {
            if (cooldownTimer <= 0)
            {
                OnAttack.Invoke();
                health.TakeDamage(damage);
                cooldownTimer = cooldown;
            }
        }
    }
}