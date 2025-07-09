using UnityEngine;

public interface IHealtthComponent 
{
    float maxHealth { get; }
    float currentHealth { get; }

    void TakeDamage(float amount);

    void Heal(float amount);

    void SetCurrentHealth(float value);
    void SetMaxHealth(float value);
}
