using UnityEngine;

public class PlayerHPSystem : MonoBehaviour
{
    [SerializeField] int maxHP;

    int hp;
    public void ModifyHP(int value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, maxHP);

        if (hp==0)
        {
            Die();
        }

        Debug.Log("Hp modified by: " + value + ", current hp: " + hp);
    }

    void Start()
    {
        hp = maxHP;
    }

    void Update()
    {
        //Видалити цей код пізніше!!!
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ModifyHP(-1);
        }
    }

    void Die()
    {
        Debug.Log("Player Died");

        //Це момент коли ти помираєш, чувак
    }
}
