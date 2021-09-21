using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class ScratchCommand : Command
    {
        public override void Execute(Monster owner, Monster target)
        {
            throw new System.NotImplementedException();
        }
    }
}