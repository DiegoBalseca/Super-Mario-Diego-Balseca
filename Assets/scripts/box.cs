using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public AudioSource _audioSource;
    public Collider2D collider;
    public AudioClip boxFCX;
    public SpriteRenderer _spriteRenderer;
    public BoxCollider2D _boxcollided1;
    public BoxCollider2D _boxcollided2;
 
   
 
 void Awake()

 {
    _audioSource = GetComponent<AudioSource>();
    _spriteRenderer = GetComponent<SpriteRenderer>();
 }
 
 
void Destroybox ()
{
    _audioSource.clip = boxFCX;
    _audioSource.Play();
    _spriteRenderer.enabled = false;
    _boxcollided1.enabled = false;
    _boxcollided2.enabled = false;

Destroy(gameObject, boxFCX.length);

} 
    void OnTriggerEnter2D(Collider2D collider)
{
    if (collider.gameObject.CompareTag ("Player"))
    {
        Destroybox();
    }
}
    





 
}
