using UnityEngine;

namespace TypeObjectPattern
{
    [CreateAssetMenu]
    public class WriggleCommand : Command
    {
        public override void Execute(Monster owner, Monster target)
        {
            if (!owner.TryGetComponent(out WriggleData data))
            {
                data = owner.gameObject.AddComponent<WriggleData>();
            }

            ++data.Charge;
            Debug.Log($"{owner}'s wriggle charge reached {data.Charge}");
        }
    }
}