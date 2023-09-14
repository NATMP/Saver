using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PlayerSO/Player")]
public class PlayerStats : ScriptableObject
{
    public int Hp;
    public int Damage;
    public int Defense;
    public int Mp;
    public int Speed;
}
