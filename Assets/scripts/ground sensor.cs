using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;

    public enemies enemies;
    private Rigidbody2D rigidBody;
    private float jumpForce = 12;
    public float jumpDamage = 5;
    void Awake()
    {
        rigidBody = GetComponentInParent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    
    {
        IsGrounded = true;
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
            //Debug.Log(collider.gameObject.name);
            //Debug.Log(collider.gameObject.transform.position);
        }
        else if(collider.gameObject.layer == 6)
        {
            enemies = collider.gameObject.GetComponent<enemies>();
            rigidBody.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
            enemies.TakeDamage(jumpDamage);
        }
    }

 void OnTriggerStay2D(Collider2D Collider)
 {
    IsGrounded = true;
 }

    void OnTriggerExit2D(Collider2D collider)
    {
        IsGrounded = false;
    }
}