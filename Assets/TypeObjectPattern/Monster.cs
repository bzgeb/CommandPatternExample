using UnityEngine;

public class Monster : MonoBehaviour
{
    public int Health;
    public int Speed;
    public int Attack;
    public MonsterType Type;

    void Start()
    {
        Health = Type.StartingHealth;
        Speed = Type.BaseSpeed;
        Attack = Type.BaseAttack;
    }

    public bool IsWeakAgainst(MonsterType type)
    {
        foreach (var weakness in Type.Weaknesses)
        {
            if (type == weakness)
                return true;
        }

        return false;
    }
}
