using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrollViewEX : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    public void OnValueChagedScrollView(Vector2 position)
    {
        text.text = $"Scrollbar Position : {position}";
    }

}
