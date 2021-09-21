using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class FlyCommand : Command
    {
        public override void Execute(Monster owner, Monster target)
        {
            throw new System.NotImplementedException();
        }
    }
}