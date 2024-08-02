using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [Header ("Panels")]
    public GameObject creditsPanel, bizantinePanel, levelsPanel, level1Panel, level2Panel, level3Panel;
    [Header ("Buttons")]
    public GameObject playButton, creditsButton, exitButton, gameName;

    [Header ("Audio")]
    public AudioSource buttonSound;

    public void EnterLevels(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    
    #region Panels

    public void OpenBizantinePanel()
    {
        bizantinePanel.SetActive(true);
        playButton.SetActive(false);
        creditsButton.SetActive(false);
        exitButton.SetActive(false);
        gameName.SetActive(false);
    }

    public void OpenLevelsPanel()
    {
        if(levelsPanel != null)
        {
            levelsPanel.SetActive(true);
            playButton.SetActive(false);
            creditsButton.SetActive(false);
            exitButton.SetActive(false);
            bizantinePanel.SetActive(false);
            level1Panel.SetActive(false);
            level2Panel.SetActive(false);
            level3Panel.SetActive(false);
            gameName.SetActive(false);
            buttonSound.Play();
        }
    }
    public void CloseLevelsPanel()
    {
        levelsPanel.SetActive(false);
        playButton.SetActive(true);
        creditsButton.SetActive(true);
        exitButton.SetActive(true);
        bizantinePanel.SetActive(false);
        level1Panel.SetActive(false);
        level2Panel.SetActive(false);
        gameName.SetActive(true);
        creditsPanel.SetActive(false);
        buttonSound.Play();
    }
    public void OpenLevel1Panel()
    {
        level1Panel.SetActive(true);
        levelsPanel.SetActive(false);
        buttonSound.Play();
    }

    public void OpenLevel2panel()
    {
        level2Panel.SetActive(true);
        levelsPanel.SetActive(false);
        buttonSound.Play();
    }

    public void OpenLevel3Panel()
    {
        level3Panel.SetActive(true);
        levelsPanel.SetActive (false);
        buttonSound.Play();
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
        playButton.SetActive(false);
        creditsButton.SetActive(false);
        exitButton.SetActive(false);
        level1Panel.SetActive(false);
        level2Panel.SetActive(false);
        gameName.SetActive(false);
        buttonSound.Play();
    }

    #endregion Panels


    public void Exit()
    {
        Application.Quit();
        buttonSound.Play();
    }
}
