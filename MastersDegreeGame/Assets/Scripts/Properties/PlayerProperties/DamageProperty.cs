﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = Characters.Object;

public class DamageProperty : BaseProperty
{
   public int value;
   public override void StartProperty(Object parent)
   {
      base.StartProperty(parent);
#if  CHEAT
      //Debug.Log("Activate DamageProperty");
#endif
   }

   protected override void UpdateProperty()
   {
      base.UpdateProperty();
   }
}
