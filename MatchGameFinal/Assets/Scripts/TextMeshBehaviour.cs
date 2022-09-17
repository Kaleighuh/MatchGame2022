using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Globalization;
using TMPro;


public class TextMeshBehaviour : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;
    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

}
