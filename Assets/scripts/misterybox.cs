using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misterybox : MonoBehaviour
{
    private Animator animator;

    private AudioSource audioSource;

    public AudioClip _misteryBoxSFX;

    private bool _isopen = false;

    public AudioClip _misteryboxSFX2;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    
    }

    void ActivatieBox()
    {
        
        if(!_isopen)
        {
            animator.SetTrigger("is used");
            audioSource.clip = _misteryBoxSFX;
            _isopen = true;
        }
        
        

        else
        {

            audioSource.clip = _misteryboxSFX2;
        }
        audioSource.Play();
    }




        void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.CompareTag("Player"))
            {
            ActivatieBox();
            }
        }
}   



