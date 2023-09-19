using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput inputActions;
    private Rigidbody2D rb;
    private float direction;
    private float speed;

    private void Awake()
    {
        inputActions = new PlayerInput();
        inputActions.Enable();
        speed = Player.Instance.Stats.MoveSpeed;
        rb = Player.Instance.Rb;
        inputActions.Land.Move.performed += ctx => 
        {
            direction = ctx.ReadValue<float>(); 
        };
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
