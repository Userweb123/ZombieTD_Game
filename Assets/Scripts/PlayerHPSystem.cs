using UnityEngine;
using System;

public class PlayerHPSystem : MonoBehaviour
{
    [SerializeField] int maxHP;

    int hp;
    public void ModifyHP(int value)
    {
        hp+=value;
        hp=Mathf.Clamp(hp, 0, maxHP);
    }

    void Start()
    {
        hp=maxHP;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ModifyHP(-1);
        }
    }
}
