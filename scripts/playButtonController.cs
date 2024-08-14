using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButtonController : MonoBehaviour
{
    public Button playButton; // Reference to the Button component
    public string playerCreationScene; // Scene name to load

    // Start is called before the first frame update
    void Start()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("PlayButton is not assigned in the Inspector.");
        }
    }

    void OnClick()
    {
        LoadScene();
        Debug.Log("Button Clicked");
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(playerCreationScene);
    }
}
