using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData_", menuName = "UnitData/Monster")]
public class MonsterData : ScriptableObject
{
    [Header("General Stats")]
    [SerializeField] private string _name;
    public string Name => _name;
    [SerializeField] private MonsterType _monsterType = MonsterType.None;
    [SerializeField] [Range(0, 100)] float _chanceToDropItem;
    [SerializeField] [Tooltip("Radius Size where monster will see the player")] private float _rangeOfAwareness;
    public float RangeOfAwareness => _rangeOfAwareness;

    [Header("Combat Stats")]
    [SerializeField] private int _damage;
    public int Damage => _damage;
    [SerializeField] private int health;
    [SerializeField] private int speed;

    [Header("Dialouge")]
    [SerializeField] [Tooltip("Speeks dialouge when entering combat")] [TextArea()] private string _battleCry;
}
