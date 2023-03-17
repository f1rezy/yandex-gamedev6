using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnterName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private TMP_InputField _inputField;

    public void SetName()
    {
        _text.text = _inputField.text;
        _inputField.text = "";
    }
}
