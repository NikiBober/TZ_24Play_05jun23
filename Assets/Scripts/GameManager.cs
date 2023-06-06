using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] PlayerInput _playerInput;
    [SerializeField] GameObject _gameOverScreen;

    public void GameOver()
    {
        _playerMovement.enabled = false;
        _playerInput.enabled = false;
        _gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
