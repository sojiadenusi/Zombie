﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public void TakeDamage(int damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
            
        }
    }

    public bool IsDead()
    {
        return isDead;
    }

    private void Die()
    {
        if (isDead)
        {
            return;
        }

        isDead = true;
        GetComponent<Animator>().SetTrigger("Die");
        
    }
}
