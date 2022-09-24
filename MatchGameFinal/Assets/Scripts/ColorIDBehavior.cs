using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDListData colorIDListDataObj;

    private void Awake()
    {
        idObj = colorIDListDataObj.currentColor;
    }
}
