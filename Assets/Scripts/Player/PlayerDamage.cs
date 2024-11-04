using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] int playerHealth = 5;
    [SerializeField] float invincibiltyTime = 2f;
    bool invincible = false;

    void DisableInvinsibility()
    {
        invincible = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if(invincible == true)
            {
                return;
            }
            if(playerHealth > 0)
            {
                playerHealth--;
                invincible = true;
                Invoke("DisableInvinsibility", invincibiltyTime);
                Debug.Log("Player health:" + playerHealth);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
