using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{

    private int _health = 100;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if(_health <= 0)
        {
            Debug.Log("Il giocatore è stato sconfitto.");
            Destroy(gameObject);
        }
        Debug.Log($"Il giocatore ha subito {damage} di danno. Vita attuale: {_health}");
    }

    public void TakeHeal(int amount)
    {
        _health += amount;
        Debug.Log($"Il giocatore ha recuperato {amount} hp. Vita attuale: {_health}");
    }


}
