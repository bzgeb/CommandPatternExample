using UnityEngine;

[CreateAssetMenu]
public class MonsterType : ScriptableObject
{
    public int StartingHealth;
    public int BaseSpeed;
    public int BaseAttack;
    public MonsterType[] Weaknesses;
}
