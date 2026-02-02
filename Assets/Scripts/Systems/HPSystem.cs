using UnityEngine;

public abstract class HPSystem : MonoBehaviour
{
    [SerializeField] protected int maxHP;
    protected int hp;

    public virtual void ModifyHP(int value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, maxHP);

        if (hp == 0)
        {
            OnDeath();
        }
    }

    protected virtual void Start()
    {
        hp = maxHP;
    }

    protected abstract void OnDeath();
}