using UnityEngine;
using TMPro; // Required for TextMeshPro

public class InfoCardManager : MonoBehaviour
{
    public GameObject infoCardPanel; // Drag your InfoCardPanel here
    public TextMeshProUGUI landmarkNameText; // Drag your LandmarkNameText here
    public TextMeshProUGUI landmarkDescriptionText; // Drag your LandmarkDescriptionText here

    void Start()
    {
        // Ensure the info card is hidden when the scene starts
        if (infoCardPanel != null)
        {
            infoCardPanel.SetActive(false);
        }
    }

    // Method to show the info card and set its content
    public void ShowInfoCard(string landmarkName, string description)
    {
        if (infoCardPanel != null)
        {
            infoCardPanel.SetActive(true); // Make the panel visible
            if (landmarkNameText != null)
            {
                landmarkNameText.text = landmarkName;
            }
            if (landmarkDescriptionText != null)
            {
                landmarkDescriptionText.text = description;
            }
            UnityEngine.Debug.Log("Info Card shown!");
        }
    }

    // Method to hide the info card
    public void HideInfoCard()
    {
        if (infoCardPanel != null)
        {
            infoCardPanel.SetActive(false); // Make the panel invisible
            UnityEngine.Debug.Log("Info Card hidden!");
        }
    }
}