using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{    
    [SerializeField] float damage = 40f;
    Player player;
  
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void AttackHitEvent()
    {
        if (player == null)
        {
            return;
        }
        player.TakeDamage(damage);

        player.GetComponent<DisplayDamage>().DisplayDamageCanvas();
        
       
    }
}
