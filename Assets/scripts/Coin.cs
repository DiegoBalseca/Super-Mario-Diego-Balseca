using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource moneda;
    public AudioClip _moneda;
    private Animator animator; 
    private SpriteRenderer renderer;
    GameManager _gameManager;
    


    void Awake()
    {
        moneda = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    void OnTriggerEnter2D(Collider2D collider)
    {

       

        if(collider.gameObject.CompareTag("Player"))
        {
             _gameManager.AddCoins();
            renderer.enabled = false;
            moneda.PlayOneShot(_moneda);

            Destroy(gameObject, 1); 
        }
        
            
    }
}
