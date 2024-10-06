using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Core.Settings.Difficulty
{
    public class DifficultyManager : MonoBehaviour
    {
        [SerializeField] private DifficultySettings _easySettings;
        [SerializeField] private DifficultySettings _hardSettings;
        
        public DifficultySettings CurrentSettings { get; private set; }

        public void SetDifficulty_EASY() => CurrentSettings = _easySettings;
        public void SetDifficulty_HARD() => CurrentSettings = _hardSettings;
        
        public void Start()
        {
            SetDifficulty_EASY();
            // TODO: move logic to UI
        }
    }
}