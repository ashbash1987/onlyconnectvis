using UnityEngine;

public class MissingVowelsRound : MonoBehaviour
{
    public MissingVowelsSet[] Sets = null;

    public TMPro.TMP_Text Connection = null;
    public TMPro.TMP_Text Clue = null;
    public TMPro.TMP_Text Answer = null;

    private int _setIndex = -1;
    private int _midsetIndex = -1;

    private void OnEnable()
    {
        _setIndex = -1;
        _midsetIndex = -1;
    }

    public void Next()
    {
        if (_setIndex == -1 || ((++_midsetIndex) == Sets[_setIndex].Clues.Length))
        {
            if ((++_setIndex) == Sets.Length)
            {
                return;
            }

            _midsetIndex = 0;
        }

        Connection.text = Sets[_setIndex].Connection;
        Clue.text = Sets[_setIndex].Clues[_midsetIndex];
        Answer.text = Sets[_setIndex].Answers[_midsetIndex];
    }
}
