using UnityEngine;
using System.Collections;
using Vuforia;

namespace Assets.Scripts
{
    public class PlayerController : UnitController, IVirtualButtonEventHandler
    {
        private VirtualButtonBehaviour virtualButton;

        void Start()
        {
            virtualButton = GetComponentInChildren<VirtualButtonBehaviour>();
            virtualButton.RegisterEventHandler(this);
        }

        protected override void Update()
        {
            base.Update();
            if (UnitManager.enemy)
            {
                transform.LookAt(UnitManager.enemy.transform);
                float dist = Vector3.Distance(transform.position, UnitManager.enemy.transform.position);

                if (!isDead && UnitManager.enemy != null && dist <= FightDistance)
                {
                    combat.Attack(UnitManager.enemy.health);
                }
            }
        }

        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
            if (!isDead && UnitManager.enemy != null)
            {
                combat.Attack(UnitManager.enemy.health);
            }
        }

        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
        }

        public override void Die()
        {
            base.Die();
            UnitManager.player = null;
        }
    }
}