using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Settings.Difficulty
{
    [CreateAssetMenu(fileName = "_DifficultyPreset", menuName = "ScriptableObject/Settings/Difficulty")]
    public class DifficultySettings : ScriptableObject
    {
        public float _playerSpeed;
    }
}