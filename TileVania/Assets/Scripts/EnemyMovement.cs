using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    [SerializeField] float moveSpeed = 1f;

    Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Start() {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if(IsFacingRight()) {
            myRigidbody2D.velocity = new Vector2(moveSpeed, 0);
        }
        else {
            myRigidbody2D.velocity = new Vector2(-moveSpeed, 0);
        }
    }

    private bool IsFacingRight() {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision) { // When hitting a wall, the thin collider technically isn't hitting the line of the wall anymore, so it exits
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody2D.velocity.x)), transform.localScale.y);
    }
}
