using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class showpetname : MonoBehaviour
{
    public Text latestSavedNameText;
    string enteredName;

    private void Update()
    {
        latestSavedNameText.text = PlayerPrefs.GetString("LatestSavedName", enteredName);
    }
}
