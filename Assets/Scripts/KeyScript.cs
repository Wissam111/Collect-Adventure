using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script represents what happen when player collect the key.

public class KeyScript : MonoBehaviour
{
    private const int PlayerLayer = 3;

    [SerializeField]
    private AudioClip collectSoundEffect;

    [SerializeField]
    private GameObject blockObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == PlayerLayer)
        {
            Destroy(gameObject); // destroy the key
            AudioSource.PlayClipAtPoint(collectSoundEffect, transform.position); //collect key sound
            Destroy(blockObject); // destroy the object that block the path
        }
    }
}
