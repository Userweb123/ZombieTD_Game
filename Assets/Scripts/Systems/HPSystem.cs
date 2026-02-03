using UnityEngine;

public abstract class HPSystem : MonoBehaviour
{
    [SerializeField] protected int maxHP;
    [SerializeField] Transform textSpawnPoint;
    static GameObject damageTextPrefab;

    protected int hp;

    public virtual void ModifyHP(int value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, maxHP);

        OnHPModified(value);

        if (damageTextPrefab != null && textSpawnPoint != null)
        {
            ShowDamageText(value);
        }

        if (hp == 0)
        {
            OnDeath();
        }
    }

    protected virtual void Start()
    {
        hp = maxHP;
    }

    protected virtual void OnDeath() {}

    protected virtual void OnHPModified(int value) {}

    void ShowDamageText(int value)
    {
        GameObject damageText = Instantiate(damageTextPrefab, textSpawnPoint.position, Quaternion.identity);

        TMPro.TextMeshPro textComponent = damageText.GetComponent<TMPro.TextMeshPro>();
        if (textComponent != null)
        {
            textComponent.text = value.ToString();

            if (value > 0)
            {
                textComponent.color = Color.green;
                textComponent.text = "+" + value.ToString();
            }
            else if (value < 0)
            {
                textComponent.color = Color.red;
            }
            else
            {
                textComponent.color = Color.white;
            }
        }
    }

    public static void SetDamageTextPrefab(GameObject prefab)
    {
        damageTextPrefab = prefab;
    }
}