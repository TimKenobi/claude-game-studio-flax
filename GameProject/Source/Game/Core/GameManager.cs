using System;
using FlaxEngine;

/// <summary>
/// Central game manager — singleton that persists across scenes.
/// Manages game state, scene transitions, and core service references.
/// </summary>
public class GameManager : Script
{
    public static GameManager Instance { get; private set; }

    [Serialize, ShowInEditor]
    private SceneReference _mainMenuScene;

    [Serialize, ShowInEditor]
    private SceneReference _firstLevelScene;

    private GameState _currentState = GameState.MainMenu;

    public GameState CurrentState => _currentState;

    public event Action<GameState, GameState> OnStateChanged;

    public override void OnEnable()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Actor);
            return;
        }
        Instance = this;
    }

    public override void OnDisable()
    {
        if (Instance == this)
            Instance = null;
    }

    public void ChangeState(GameState newState)
    {
        if (_currentState == newState)
            return;

        var previousState = _currentState;
        _currentState = newState;
        OnStateChanged?.Invoke(previousState, newState);
    }

    public void StartNewGame()
    {
        ChangeState(GameState.Loading);
        // TODO: Load first level scene
        ChangeState(GameState.Playing);
    }

    public void PauseGame()
    {
        if (_currentState != GameState.Playing)
            return;
        Time.TimeScale = 0f;
        ChangeState(GameState.Paused);
    }

    public void ResumeGame()
    {
        if (_currentState != GameState.Paused)
            return;
        Time.TimeScale = 1f;
        ChangeState(GameState.Playing);
    }

    public void ReturnToMainMenu()
    {
        Time.TimeScale = 1f;
        ChangeState(GameState.MainMenu);
        // TODO: Load main menu scene
    }
}

public enum GameState
{
    MainMenu,
    Loading,
    Playing,
    Paused,
    Cutscene,
    Dialog,
    GameOver
}
