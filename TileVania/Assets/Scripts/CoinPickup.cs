﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int scoreValue = 100;

    private void OnTriggerEnter2D(Collider2D collision) {
        FindObjectOfType<GameSession>().AddScore(scoreValue);
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }

}
