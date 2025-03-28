using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public float direction = 1;
    
    public float speed = 5;

    public Animator _animator;
    
    private AudioSource _audioSource;

    private Rigidbody2D _rigidBody;

    private AudioClip _AudioSFX;

    public BoxCollider2D _boxcollider

    

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _boxcollider = GetComponent<_boxcolider>();
        
        
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _rigidBody.velocity = new Vector2 (direction * speed, _rigidBody.velocity.y );
    }

    public void dead()
    {
        _animator.SetTrigger("is dead");
        Destroy(gameObject. 0,3); 
    }

    void OnCollisionEnter2D (Collision2D collision)
{
    direction *= -1;

    if(collision.gameObject.CompareTag("Player"))
    {
        Destroy(collision.gameObject);
    }
}
    
}
