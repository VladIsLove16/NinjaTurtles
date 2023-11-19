using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy, IDamageAble
{
    [SerializeField]
    private int defense=0;

    public void GetHit(int dmg)
    {
        int damageDealt = dmg - defense;
        health -= damageDealt;
        Console.WriteLine($"������� ����� ����� �����������, ���������� ����: {damageDealt} �� {dmg}");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
