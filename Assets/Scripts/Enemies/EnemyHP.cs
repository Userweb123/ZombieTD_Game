using UnityEngine;

public class EnemyHP : HPSystem
{
    protected override void OnDeath()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        //видалити пізніше!
        if (Input.GetKeyDown(KeyCode.J))
        {
            ModifyHP(Random.Range(-5, 5));
        }
    }

    //видалити пізніше!
    void OnMouseDown()
    {
        ModifyHP(-1);
    }
}
