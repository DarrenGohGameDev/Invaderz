using UnityEngine;
using static HealthComponent;

public class HealthComponent : MonoBehaviour , IHealtthComponent
{
    [SerializeField] protected float maxHp = 100f;

    public delegate void OnTakeDamage(float amouunt);
    public OnTakeDamage onTakeDamage;

    public delegate void OnDeath();
    public OnDeath onDeath;

    protected float currentHp;
    public float currentHealth => currentHp;
    public float maxHealth => maxHp;

    public void TakeDamage(float amount)
    {
        currentHp -= amount;
        onTakeDamage?.Invoke(amount);
        if (currentHp <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        onDeath?.Invoke();
        Debug.Log($"{this.gameObject.name} have died");
    }
}