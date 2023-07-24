using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowFieldName : MonoBehaviour

{
    public TextMeshProUGUI fieldNameText;
    public GameObject fieldName = null;

    void update()
    {
        Text fieldNameText = fieldName.GetComponent<Text>();
        fieldNameText.text = "000000";
    }

}
