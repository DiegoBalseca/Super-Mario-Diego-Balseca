using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource moneda;
    public AudioClip _moneda;
    private Animator animator; 
    private SpriteRenderer renderer;
    


    void Awake()
    {
        moneda = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            renderer.enabled = false;
            moneda.PlayOneShot(_moneda);

            Destroy(gameObject, 1); 
        }
        
            
    }
}
