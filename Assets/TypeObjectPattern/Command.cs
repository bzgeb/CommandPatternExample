using UnityEngine;

public abstract class Command : ScriptableObject
{
    public abstract void Execute(Monster owner, Monster target);
}
