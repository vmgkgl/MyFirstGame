using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEX : MonoBehaviour
{
    [SerializeField]
    private GameObject warrior;
    [SerializeField]
    private GameObject warrior1;
    [SerializeField]
    private GameObject warrior2;
    [SerializeField]
    private GameObject warrior3;

    public void OnValuechangedEvent(bool isOn)
    {
        warrior.SetActive(isOn);
    }
    public void OnValuechangedEvent1(bool isOn)
    {
        warrior1.SetActive(isOn);
    }
    public void OnValuechangedEvent2(bool isOn)
    {
        warrior2.SetActive(isOn);
    }
    public void OnValuechangedEvent3(bool isOn)
    {
        warrior3.SetActive(isOn);
    }
}
