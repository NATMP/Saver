using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputManager : SingletonGeneric<PlayerInputManager>
{
    private float direction;
    private bool isMoving;

    public float Direction { get => direction; set => direction = value; }
    public bool IsMoving { get => isMoving; set => isMoving = value; }
}
