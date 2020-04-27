using UnityEngine;

namespace Characters.Animations
{
    public class NpcAnimatorController : CharacterAnimatorController
    {
        public NpcAnimatorController(Animator animatorController) : base(animatorController){}
        
        public override void OnMove(float speedFactor, int energy) {
            // AnimatorController.SetFloat(MovementSpeedFactor, speedFactor, 
            //     smoothingFactor, Time.deltaTime);
        }

        public override void OnAttackMelee() {
            AnimatorController.SetTrigger(AttackMelee);
        }

        public override void OnTakeDamage() {
            AnimatorController.SetTrigger(TakeDamage);
        }

        public override void OnDie() {
            AnimatorController.SetBool(Die, true);
        }
    }
}