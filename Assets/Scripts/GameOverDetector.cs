using UnityEngine;

public class GameOverDetector : MonoBehaviour
{
    [SerializeField] GameObject _ragdoll;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            ActivateRagdoll();
            GameManager.Instance.GameOver();
        }
    }

    private void ActivateRagdoll()
    {
        Destroy(GetComponent<Rigidbody>());
        Destroy(GetComponent<BoxCollider>());
        Destroy(GetComponent<Animator>());
        _ragdoll.SetActive(true);
    }
}