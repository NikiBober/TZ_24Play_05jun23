using System.Collections;
using UnityEngine;

public class StackController : Singleton<StackController>
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private GameObject _textObject;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private float _textDelay = 1f;
 

    public void IncreaseStack(GameObject cube)
    {
        transform.Translate(Vector3.up);
        cube.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        cube.transform.SetParent(transform);
        cube.tag = "InStack";

        ActivateEffects();
    }

    private void ActivateEffects()
    {
        JumpAnimation();
        PlayParticle();
        StartCoroutine(ShowTextRoutine());
    }

    private void JumpAnimation()
    {
        _playerAnimator.SetTrigger("Jump");
    }

    private void PlayParticle()
    {
        _particle.Play();
    }

    private IEnumerator ShowTextRoutine()
    {
        _textObject.SetActive(true);
        yield return new WaitForSeconds(_textDelay);
        _textObject.SetActive(false);
    }
}
