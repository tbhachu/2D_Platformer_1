using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Pickup : MonoBehaviour
{

    [SerializeField] AudioClip coinPickupSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.tag == "Player")
            {
                AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
                Destroy(gameObject);
            }
            
        }
    }
}
