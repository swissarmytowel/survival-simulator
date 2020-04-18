﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : Object
{
    public HealthProperty Health { get; private set; }
    public HungerProperty Hunger { get; private set; }
    public DamageProperty Damage { get; private set; }
    public WarmProperty Warm { get; private set; }
    public EnergyProperty Energy { get; private set; }

    protected override void Start()
    {
        base.Start();
        Health = GetComponent<HealthProperty>();
        Hunger = GetComponent<HungerProperty>();
        Damage = GetComponent<DamageProperty>();
        Warm = GetComponent<WarmProperty>();
        Energy = GetComponent<EnergyProperty>();
    }
}