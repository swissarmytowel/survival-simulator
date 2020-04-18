﻿using UnityEngine;

namespace InventoryObjects.Items
{
    // Weapon items can be used as tools
    [CreateAssetMenu(fileName = "Create New Weapon", menuName = "Inventory/Items/Weapon")]
    public class WeaponItem : ItemObject
    {
        public float attackPower;

        public GameObject weaponPrefab;
        
        private void Awake() {
            ItemType = ItemObjectType.Weapon;
        }

        public override void OnUse(Object target) {
            throw new System.NotImplementedException();
        }

        public override void OnThrowOut() {
            throw new System.NotImplementedException();
        }

        public override void OnPickUp() {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate() {
            throw new System.NotImplementedException();
        }
    }
}