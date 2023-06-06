using UnityEngine;

public class GameOverDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            GameManager.Instance.GameOver();
        }
    }
}