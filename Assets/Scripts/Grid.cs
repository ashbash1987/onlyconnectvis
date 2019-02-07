using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public SequencesRound NormalRound = null;
    public SequencesRound AudioRound = null;
    public SequencesRound PicturesRound = null;
    public Sequence[] Sequences = null;

    private Button[] _buttons = null;
    private int _selectionIndex = -1;

    private void Awake()
    {
        _buttons = GetComponentsInChildren<Button>();
    }

    private void OnEnable()
    {
        _selectionIndex = -1;
    }

    public void SetSelection(int index)
    {
        _selectionIndex = index;
    }

    public void Play()
    {
        _buttons[_selectionIndex].interactable = false;

        if (Sequences[_selectionIndex].IsAudio)
        {
            AudioRound.Set(Sequences[_selectionIndex]);
            AudioRound.gameObject.SetActive(true);
        }
        else if (Sequences[_selectionIndex].IsPictures)
        {
            PicturesRound.Set(Sequences[_selectionIndex]);
            PicturesRound.gameObject.SetActive(true);
        }
        else
        {
            NormalRound.Set(Sequences[_selectionIndex]);
            NormalRound.gameObject.SetActive(true);
        }
    }
}
