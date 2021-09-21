using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class AttackCommand : Command
    {
        public string ConsoleMessage;
        
        public override void Execute(Monster owner, Monster target)
        {
            Debug.Log($"{owner} {ConsoleMessage} {target}");
            var attackDamage = Mathf.CeilToInt(owner.Attack * (target.IsWeakAgainst(owner.Type) ? 1.5f : 1f));
            target.Health -= attackDamage;
        }
    }
}