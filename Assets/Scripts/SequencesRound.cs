using UnityEngine;

public class SequencesRound : MonoBehaviour
{
    public TMPro.TMP_Text[] Clues = null;

    public TMPro.TMP_Text Connection = null;

    public void Set(Sequence sequence)
    {
        for (int clueIndex = 0; clueIndex < sequence.Clues.Length; ++clueIndex)
        {
            Clues[clueIndex].text = sequence.Clues[clueIndex];
        }

        Connection.text = sequence.Connection;
    }
}
