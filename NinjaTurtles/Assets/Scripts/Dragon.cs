using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy, IDamageAble
{
    [SerializeField]
    private int defense=5;

    public void GetHit(int dmg)
    {
        int damageDealt= dmg - defense;
        health -= damageDealt;
        Debug.Log($"������� ����� ������� ��������� ����: {damageDealt} �� {dmg} ");

        if(health<1)
        {
            //_anim.SetTrigger(_deathAnimHash);
           // Destroy(gameObject);
        }
        else
        {
            //_anim.SetTrigger(_hitAnimHash);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
