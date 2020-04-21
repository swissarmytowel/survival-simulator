﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWindow : BaseWindow
{
   public void OnPlayButtonClick()
   {
      MenuController.Instance.HideWindow();
      
      SceneLoaderController.Instance.LoadStartScene();
      
   }

   public void OnQuitApplication()
   {
      Application.Quit();
   }

   public void OnQuitApplication()
   {
      Application.Quit();
   }
}
