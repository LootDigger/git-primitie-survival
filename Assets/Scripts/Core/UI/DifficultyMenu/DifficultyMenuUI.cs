using System.Collections;
using System.Collections.Generic;
using Core.Settings.Difficulty;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class DifficultyMenuUI : MonoBehaviour
{
    [Inject]
    DifficultyManager difficultyManager;

    public void OnEasyButtonClicked()
    {
        difficultyManager.SetDifficulty_EASY();
        SceneManager.LoadScene("MainScene");
    }

    public void OnHardButtonClicked()
    {
        difficultyManager.SetDifficulty_HARD();
        SceneManager.LoadScene("MainScene");
    }
}
