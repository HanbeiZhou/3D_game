using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootingPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletAmount = 100;
    public float fireRate;
    Animator animator;

    private void Awake(){
        animator = GetComponent<Animator>();
    }
    public void OnFire(InputValue value)
    {
        animator.SetBool("Shooting", value.isPressed);
        if(value.isPressed) {
            print("shooting...");
            Shoot();
            InvokeRepeating("Shoot", fireRate, fireRate);

        } else {
            CancelInvoke();
        }
    }
    private void Shoot(){
        print("shooting in shoot");
        if (bulletAmount > 0 && Time.timeScale > 0){
            print("shooting in shoot later");
            bulletAmount--;
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootingPoint.transform.position;
            clone.transform.rotation = shootingPoint.transform.rotation;
            muzzleEffect.Play();
            shootSound.Play();
        }
    }
}
