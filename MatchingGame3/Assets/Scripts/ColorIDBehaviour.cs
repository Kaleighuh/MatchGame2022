using UnityEngine;

public class ColorIDBehavior : IDContainerBehaviour
{
    public ColorIDListData colorIDListDataObj;

    private void Awake()
    {
        idObj = colorIDListDataObj.currentColor;
    }
}
