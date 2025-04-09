using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemies : MonoBehaviour
{
    private Slider _healthBar;

    private Animator animator;
    private AudioSource audioSource;

    public AudioClip goombadeathSFX;
    private Rigidbody2D rigidBody;
    public int direction = -1;
    public float speed = 5;
    public float maxHealth = 10;
    private float currentHealt;
    GameManager _gameManager;



    private BoxCollider2D boxCollider;
    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        _healthBar = GetComponentInChildren<Slider>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Start()
    {
        speed = 0;

        currentHealt = maxHealth;
        _healthBar.maxValue = maxHealth;
        _healthBar.value = maxHealth;
    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(direction * speed, rigidBody.velocity.y);
    }

    public void Death()
    {
        direction = 0;
        rigidBody.gravityScale = 0;
        animator.SetTrigger("is dead");
        boxCollider.enabled = false;
        Destroy(gameObject, 0.3f);
        _gameManager.AddGoombas();
    }

    public void TakeDamage(float damage)
    {
        currentHealt-= damage;

        _healthBar.value = currentHealt;

        if (currentHealt <= 0)
        {
            Death();
        } 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Tuberia") || collision.gameObject.layer == 6 || collision.gameObject.layer == 10);
        {
            direction *= -1;
        }
        
        if(collision.gameObject.CompareTag("Player"))
        {
            //Destroy(collision.gameObject);
            Mario playerScript = collision.gameObject.GetComponent<Mario>();
            playerScript.Death();
        }
        
    }

    




    void OnBecameVisible()
    {
        speed = 2;
    }

    void OnBecameInvisible()
    {
        speed = 0;
    }



}
