using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private MonsterData _data;

    private void Awake()
    {
        Debug.Log("Damage : " + _data.Damage);
    }

    private void OnDrawGizmos()
    {
        //if You want to display gizmo all the time
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, _data.RangeOfAwareness);

        Gizmos.color = Color.red;
        Vector3 direction = transform.forward * _data.RangeOfAwareness;
        Gizmos.DrawRay(transform.position, direction);
    }
}
