using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
    }
    public System.Action onDead;
    public System.Action onHealthChanged;

    public int defaultHealthPoint = 100;
    public int healthPoint;

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;
        onHealthChanged?.Invoke();

        if (healthPoint <= 0) Die();
    }

}
