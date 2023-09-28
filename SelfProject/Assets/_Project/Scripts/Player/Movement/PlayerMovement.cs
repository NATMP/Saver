using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;

    private void Awake()
    {
        speed = Player.Instance.Stats.MoveSpeed;
        rb = Player.Instance.Rb;
    }
    private void FixedUpdate()
    {
        if(PlayerInputManager.Instance != null && PlayerInputManager.Instance.IsMoving)
            rb.velocity = new Vector2(PlayerInputManager.Instance.Direction * speed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
