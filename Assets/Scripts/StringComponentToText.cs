using UnityEngine;

[ExecuteInEditMode]
public class StringComponentToText : MonoBehaviour
{
    public StringComponent Component = null;

    private TMPro.TMP_Text _text = null;

    private void Awake()
    {
        _text = GetComponent<TMPro.TMP_Text>();
    }

    private void Update()
    {
        if (Component != null)
        {
            _text.text = Component.Value;
        }
    }
}
