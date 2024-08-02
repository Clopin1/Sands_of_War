using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
{
    public GameObject winPanel, losePanel, pausePanel, endLevelPanel, instructionsPanel;
    public int alliesSpawners;
    public int enemiesSpawners;
    public AudioSource buttonSound;

    public void Awake()
    {
        if (instructionsPanel == true)
        {
            Time.timeScale = 0f;
        }
    }

    public void Start()
    {
        alliesSpawners = 3;
        enemiesSpawners = 3;
    }

    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
            buttonSound.Play();
        }
    }

    public void DespauseGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        buttonSound.Play();
    }

    public void GameOver()
    {
        if (enemiesSpawners <= 1)
        {
            winPanel.SetActive(true);
            losePanel.SetActive(false);

            Time.timeScale = 0f;
        }
        if (alliesSpawners <= 1)
        {
            losePanel.SetActive(true);
            winPanel.SetActive(false);

            Time.timeScale = 0f;
        }
    }

    public void OpenEndLevelPanel( )
    {
        endLevelPanel.SetActive(true);
        winPanel.SetActive(false);
        buttonSound.Play();

        Time.timeScale = 0f;
    }



    public GameObject firstSpawnerPanel, secondSpawnerPanel, thirdSpawnerPanel;


    #region Panels
    public void OpenFirstSpawnerPanel()
    {
        firstSpawnerPanel.SetActive(true);
        secondSpawnerPanel.SetActive(false);
        thirdSpawnerPanel.SetActive(false);
        buttonSound.Play();
    }

    public void OpenSecondSpawnerPanel()
    {
        firstSpawnerPanel.SetActive(false);
        secondSpawnerPanel.SetActive(true);
        thirdSpawnerPanel.SetActive(false);
        buttonSound.Play();
    }

    public void OpenThirdSpawnerPanel()
    {
        firstSpawnerPanel.SetActive(false);
        secondSpawnerPanel.SetActive(false);
        thirdSpawnerPanel.SetActive(true);
        buttonSound.Play();
    }

    public void CloseInstructions()
    {
        instructionsPanel.SetActive(false);
        Time.timeScale = 1.0f;
        buttonSound.Play();
    }

    #endregion Panels

    public void Retry(string cena)
    {
        SceneManager.LoadScene(cena);
        buttonSound.Play();
    }

    public void Update()
    {
        GameOver();

        PauseGame();
    }
}
