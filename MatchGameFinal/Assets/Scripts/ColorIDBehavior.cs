using UnityEngine;

public class ColorIDBehavior : IDContainer
{
    public ColorIDListData colorIDListDataObj;

    private void Awake()
    {
        idObj = colorIDListDataObj.currentColor;
    }
}
