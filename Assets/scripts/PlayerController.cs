using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 4.5f;
    public int direction = 1;
    private float inputHorizontal;
    private Rigidbody2D rigidBody;
    public float jumpForce = 10;
    public groundsensor groundsensor;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip jumpSFX;
    public Transform posicion;
    public GameObject _gameobject; 
    public AudioClip shootSFX;
    public bool Canshoot _canshoot;
    public float PowerUpTime _poweruptime = 20
    public float PowerUpFire _powerupfire


    void Awake()
    { 
        rigidBody = GetComponent<Rigidbody2D>();
        groundsensor = GetComponentInChildren<groundsensor>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    void Start()
    {
        //tp al goomba
        //transform.position = new Vector3 (0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        //transform.position = new Vector3(transform.position.x + direction * playerSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        //transform.Translate(new Vector3 (direction * playerSpeed * Time.deltaTime, 0, 0));
        //transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + inputHorizontal, transform.position.y), playerSpeed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && groundsensor.IsGrounded)
        {
            Jump();
        }
        Movement();
        animator.SetBool("is jumping", !groundsensor.IsGrounded);
        /*if(groundSensor.IsGrounded)
        {
            animator.SetBool("IsJumping", false);
        else
        {
            animator.SetBool("IsJumping", true)
        }*/

        if input.GetButtonDown("Fire")
        {
            shoot()
        }


        void shoot()
        {
            instanted(...).rotati
        } 
        AudioClip.PlayOneShoot

        PowerUp timer += deltaTime
        if(Power timer) <= 
        Canshoot = Time

    }
    
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(inputHorizontal * playerSpeed, rigidBody.velocity.y);
        //rigidBody.AddForce(new Vector2(inputHorizontal, 0));
        //rigidBody.MovePosition(new Vector2(100, 0));
    }

    void Movement()
    {
        if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.eurel (0, 0, 0)
            spriteRenderer.flipX = false;
            animator.SetBool("is running", true);
        }
        else if(inputHorizontal < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("is running", true);  
        }
        else
            animator.SetBool("is running", false);
        
            
    }
    void Jump()
    {
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        animator.SetBool("is jumping", true);
        audioSource.PlayOneShot(jumpSFX);
    }
    
    void PowerUp()
    {
        PowerUp timer += deltaTime
        if(Power timer) <= 
        Canshoot = false
        PowerUp timer = 0
    }


}
    

       
