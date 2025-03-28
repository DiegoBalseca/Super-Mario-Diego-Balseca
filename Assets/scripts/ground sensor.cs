using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundsensor : MonoBehaviour
{
    public bool IsGrounded;

    public enemies _enemies;

    public Rigidbody2D _rigibody;

    void OnTriggerEnter2D(Collider2D collider)

    {
        IsGrounded = true;
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
            Debug.Log(collider.gameObject.name);
            Debug.Log(collider.gameObject.transform.position);
        }

        else if (collider.gameObject.layer == 6)

        Destroy(collider.gameObject);

        (
            enemieScript = collider gameObject GetComponent
        )

    void Awake()
    GetComponent Inparent
    AddForce 
    

        
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