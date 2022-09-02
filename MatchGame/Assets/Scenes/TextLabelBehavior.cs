using System.Globalization;
using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
   public Text Label;
   public Float dataObj;
   private void Start()
   {
      Label = GetComponent<Text>();
      UpdateLabel();
   }

   public void UpdateLabel()
   {
      Label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
   }
}
