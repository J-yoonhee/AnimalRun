using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    public GameObject[] CarPrefab;

    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player)
        {
            int carIndex = PlayerPrefs.GetInt("CurrentCar");
            GameObject car = Instantiate(CarPrefab[carIndex]);
            car.transform.SetParent(player.transform);
            car.transform.localPosition = new Vector3(0, 0, 0);



        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("StageScene");
    }


    public void BackButton()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void NextButton()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void ResetButton()
    {
        PlayerPrefs.DeleteAll();
    }

    public void TutorialButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Level1Button()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Level2Button()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void Level3Button()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void Level4Button()
    {
        SceneManager.LoadScene("Level_4");
    }
    public void CharacterSelect()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void StageBackButton()
    {
        SceneManager.LoadScene("StageScene");
    }

    public void TutorialBackButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
