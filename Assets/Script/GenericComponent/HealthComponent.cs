using UnityEngine;
using static HealthComponent;

public class HealthComponent : MonoBehaviour , IHealtthComponent
{
    [SerializeField] protected float maxHp = 100f;

    public delegate void OnTakeDamage(float amouunt);
    public event OnTakeDamage onTakeDamage;

    public delegate void OnDeath();
    public event OnDeath onDeath;

    private float currentHp;
    public float currentHealth
    {
        get => currentHp;
    }
    public float maxHealth
    {
        get => maxHp;
    }

    public virtual void Awake()
    {
        currentHp = maxHp;
    }

    public void TakeDamage(float amount)
    {
        currentHp -= Mathf.Abs(amount);
        onTakeDamage?.Invoke(amount);
        if (currentHp <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        currentHp += Mathf.Clamp(Mathf.Abs(amount),0,maxHp);
    }

    public void SetCurrentHealth(float value)
    {
        currentHp = Mathf.Clamp(Mathf.Abs(value), 0, maxHp);
    }

    public void SetMaxHealth(float value)
    {
        maxHp = value;
    }

    public virtual void Die()
    {
        onDeath?.Invoke();
        Debug.Log($"{this.gameObject.name} have died");
    }
}