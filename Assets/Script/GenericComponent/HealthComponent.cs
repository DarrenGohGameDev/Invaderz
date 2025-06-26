using UnityEngine;

public class HealthComponent : MonoBehaviour , IHealtthComponent
{
    [SerializeField] protected float maxHp = 100f;

    protected float currentHp;
    public float currentHealth => currentHp;

    public float maxHealth => maxHp;

    public void TakeDamage(float amount)
    {
        currentHp -= amount;

        if(currentHp <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log($"{this.gameObject.name} have died");
    }
}