using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private CameraController _camera;


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

    public void CollisionEffects()
    {
        ShakeCamera();
        VibrateDevice();
    }

    private void ShakeCamera()
    {
        _camera.Shake();
    }

    private void VibrateDevice()
    {
        //not sure about this code, cause haven`t physical device to test
        Handheld.Vibrate();
    }

}
