using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField]
    private int healAmount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<LifeController>();
        if(player != null)
        {
            player.TakeHeal(healAmount);
            Destroy(gameObject);
        }
    }

}
