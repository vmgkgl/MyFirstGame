
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class Slider2 : MonoBehaviour
{
    [SerializeField]
    private Slider sliderHp;

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private SpriteRenderer starRenderer;

    [SerializeField]
    private Button buttonAttack;

    private float maxHp = 100;
    private float currentHp;
    private float damage = 12;

    private void Awake()
    {
        currentHp = maxHp;
        text.text = $"{currentHp / maxHp:P0}";
    }

    public void OnClickEvent()
    {
        if (currentHp > 0)
        {
            currentHp -= damage;
            currentHp = Mathf.Max(currentHp, 0);
            Debug.Log($"currentHp : {currentHp}");

            sliderHp.value = currentHp / maxHp;
            text.text = $"{currentHp / maxHp:P0}";

            StartCoroutine("ColorAnimation");
        }
        else
        {
            buttonAttack.interactable = false;
        }
    }

    private IEnumerator ColorAnimation()
    {
        starRenderer.color = Color.red;
        //0.1√  ΩÆ¥Ÿ.
        yield return new WaitForSeconds(0.1f);
        starRenderer.color = Color.white;
    }

    public void OnValueChanged(float value)
    {
        text.text = $"Volume : {value * 100:F1}%";
    }

    public void OnValueChangedAlpha(float value)
    {
        Color color = starRenderer.color;
        color.a = value;
        starRenderer.color = color;

        text.text = $"Alpha : {value * 255:F0}";
    }
}
