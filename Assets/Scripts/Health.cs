using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int maxValue = 10;

        private int value;
        public int curHealth { get { return value; } }

        void Start()
        {
            value = maxValue;
        }

        public void TakeDamage(int damage)
        {
            if (value > 0)
            {
                value -= damage;
                if (value < 0)
                {
                    value = 0;
                }
            }
        }
    }
}