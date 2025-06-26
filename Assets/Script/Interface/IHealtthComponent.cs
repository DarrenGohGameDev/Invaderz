using UnityEngine;

public interface IHealtthComponent 
{
    float maxHealth { get; }
    float currentHealth { get; }

    void TakeDamage(float amount);
}
