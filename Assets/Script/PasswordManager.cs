using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private TMP_InputField inputField;

    public void OnValueChangedEvent()
    {
        text.text = "입력중...";
    }

    public void OnEndEditEvent()
    {
        text.text = inputField.text;
        if(inputField.text.Equals("1234"))
        {
            text.text = "Login!";
        }
        else
        {
            text.text = "Fail!";
        }
    }
    public void OnSeleectEvent()
    {
        text.text = "선택";
    }
    public void OnDeslectEvent()
    {
        text.text = "미선택";
    }
}
