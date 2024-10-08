using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpgradablePerk
{
   public int CurrentLevel { get; set; }
   public int MaxLevel { get; set; }
   
   void LevelUp();
}
