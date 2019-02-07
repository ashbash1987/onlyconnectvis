using UnityEngine;

public class Clue : MonoBehaviour
{
    private Animator _animator = null;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void ShowClue()
    {
        _animator.SetTrigger("ShowClue");
    }

    public void ShowTimer()
    {
        _animator.SetTrigger("ShowTimer");
    }

    public void HideTimer()
    {
        _animator.SetTrigger("HideTimer");
    }

    public void ResetClue()
    {
        _animator.SetTrigger("Reset");
    }
}
