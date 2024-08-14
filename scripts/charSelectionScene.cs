using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class charSelectionScene : MonoBehaviour
{
    public InputField PlayerName;
    public Button continueButton;
    public Dropdown dropdown;

    // New fields to store player name and team
    public string playerName;
    public string playerTeam;
    public Button continuteButton;
    public string mainGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        if (continuteButton != null)
        {
            continuteButton.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("PlayButton is not assigned in the Inspector.");
        }
    }

    // New method to store player name and team
    private void StorePlayerData()
    {
         playerName = PlayerName.text;
        playerTeam = dropdown.options[dropdown.value].text;
    }
    void LoadScene()
    {
        SceneManager.LoadScene(mainGameScreen);
    }
    // Method to handle button click
    private void OnClick()
    {
        LoadScene();
        StorePlayerData();
        Debug.Log("Button Clicked");
        // Now you can access the player name and team using the public fields
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Player Team: " + playerTeam);
        // Load the next scene
    }
 
}

    

