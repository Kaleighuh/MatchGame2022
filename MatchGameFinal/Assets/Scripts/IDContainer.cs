using UnityEngine;
using UnityEngine.Events;

public class IDContainer : MonoBehaviour
{
   public IDObj IDs;
   public UnityEvent startEvent;

   public void Start()
   {
      startEvent.Invoke();
   }

}
