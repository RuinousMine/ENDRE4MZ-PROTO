using UnityEngine;
using AC;
using TMPro;

public class ItemDescription : MonoBehaviour
{
public int invPropertyID = 1; // Set this as appropriate
public int stringVariableID = 7; // Set this as appropriate
public TextMeshProUGUI inventoryText;
public string invItemDescription;
public string inventoryBoxName;
public bool imageNeeded;
public UnityEngine.UI.RawImage rawImage;

void OnEnable()
{
    EventManager.OnMouseOverMenu += OnMouseOverMenu;
}

void OnDisable()
{
    EventManager.OnMouseOverMenu -= OnMouseOverMenu;
}

void OnMouseOverMenu(Menu menu, MenuElement element, int slot)
{
    if (element != null && !string.IsNullOrEmpty(inventoryBoxName) && element.title == inventoryBoxName)
    {
        MenuInventoryBox inventoryBox = element as MenuInventoryBox;
        InvInstance mouseOverInvInstance = inventoryBox.GetInstance(slot);
        if (InvInstance.IsValid(mouseOverInvInstance))
        {
            invItemDescription = mouseOverInvInstance.GetProperty(invPropertyID).GetValue(Options.GetLanguage());
            GlobalVariables.SetStringValue(stringVariableID, invItemDescription);
            inventoryText.text = invItemDescription;
            if (imageNeeded)
            {
                rawImage.texture = mouseOverInvInstance.InvItem.tex;
            }
        }
    }
}
}