﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;


    private Animator anim;
    private Rigidbody2D myRigidBody;

    private bool playerMoving;
    private Vector2 lastMove;


    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();

        //Não destruir o gameobject quando houver uma mudança de cenario
        DontDestroyOnLoad(transform.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //movimentação do player
            myRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidBody.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

    
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //movimentação do player
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            myRigidBody.velocity = new Vector2(0f, myRigidBody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") <  0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, 0f);
        }
        //Animações
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}
    
