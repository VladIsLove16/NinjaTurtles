using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Character : MonoBehaviour
{
    public TextMeshProUGUI text;
    //public CharacterController controller;
    [Header("Attack Properies")]
    [SerializeField]
    private Transform _attackPoint;
    [SerializeField]
    private float _attackRange;
    [SerializeField]
    private int _attackPower;

    //
    [SerializeField]
    private LayerMask _attackMask;
    //
    private void OnDrawGizmos()
    {
        if (_attackPoint == null) return;
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(_attackPoint.position, _attackRange);
        }
    }
    public void Attack()
    {
        Collider2D[] targets = Physics2D.OverlapCircleAll(_attackPoint.position, _attackRange, _attackMask);

        Debug.Log(targets.Length);
        foreach (var target in targets)
        {
            if(target.TryGetComponent(out IDamageAble hit))
            {
                hit.GetHit(_attackPower);
            }
        }
    }
    private void Update()
    {
       
    }
}
