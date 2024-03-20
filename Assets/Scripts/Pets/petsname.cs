using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class petsname : MonoBehaviour
{
    public InputField nameInputField;
    public Text latestSavedNameText;
    public Text allSavedNamesText;
    string enteredName;

    private List<string> savedNames = new List<string>();

    private void Start()
    {
        LoadNames();
        DisplayAllSavedNames();
    }

    public void SaveName()
    {
        enteredName = nameInputField.text;
        if (!string.IsNullOrEmpty(enteredName))
        {
            savedNames.Add(enteredName);
            PlayerPrefs.SetString("SavedNames", string.Join(",", savedNames.ToArray()));
            PlayerPrefs.SetString("LatestSavedName", enteredName);
            PlayerPrefs.Save();
            DisplayAllSavedNames();
        }
    }

    private void LoadNames()
    {
        string savedNamesString = PlayerPrefs.GetString("SavedNames", "");
        if (!string.IsNullOrEmpty(savedNamesString))
        {
            savedNames.AddRange(savedNamesString.Split(','));
        }
    }

    private void DisplayAllSavedNames()
    {
        latestSavedNameText.text =  PlayerPrefs.GetString("LatestSavedName", enteredName);
        allSavedNamesText.text = string.Join("\n", savedNames);
    }
}
