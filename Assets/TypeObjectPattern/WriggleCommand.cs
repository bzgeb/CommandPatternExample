using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class WriggleCommand : Command
    {
        public override void Execute(Monster owner, Monster target)
        {
            Debug.Log($"{owner} wriggled uncontrollably");
        }
    }
}