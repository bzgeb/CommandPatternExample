using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class FlyCommand : Command
    {
        public override void Execute(Monster owner, Monster target)
        {
            Debug.Log($"{owner} flew around aimlessly");
        }
    }
}