using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private int speed = 5;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
    }
    private void OnMovement(InputValue value){
        movement = value.Get<Vector2>();
        if (movement.x != 0 || movement.y != 0){
            anim.SetBool("IsWalking", true);
            anim.SetFloat("X", movement.x);
            anim.SetFloat("Y", movement.y);}
        else {
            anim.SetBool("IsWalking", false);
        }
    }
    private void FixedUpdate(){
        rb.velocity=movement*speed;
    }
}
