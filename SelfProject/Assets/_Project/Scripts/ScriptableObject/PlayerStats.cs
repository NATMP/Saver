using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PlayerSO/Player")]
public class PlayerStats : ScriptableObject
{
    [Header("Normal Stats")]
    public int MoveSpeed;
    public float JumpForce;
    [Header("Move Speed Reduce Stats")]
    public int MoveSpeedReduce;
    [Header("Jump Force Reduce Stats")]
    public float JumpForceReduce;
}
