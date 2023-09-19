using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonGeneric<Player>
{
    [SerializeField] private PlayerStats stats;
    [SerializeField] private Rigidbody2D rb;

    public PlayerStats Stats { get => stats; }
    public Rigidbody2D Rb { get => rb; }
}
