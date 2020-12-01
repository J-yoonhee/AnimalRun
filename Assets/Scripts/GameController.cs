using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{
    
    public static bool isTutorialNext = false;
    public static bool isStageNext = false;

    public VideoPlayer video;

    public GameObject videoscreen;
    public GameObject Endscreen;
    public GameObject TutorialEndscreen;

    public Button skipButton;
    public Button stageNextButton;
    public Button tutorialNextButton;
    
    public GameObject[] CarPrefab;
    public Text start_text;
    public List<GameObject> Stage = new List<GameObject>();



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

        stageNextButton.onClick.AddListener(() => // 클리어하고 스테이지화면으로 돌아감
        { 
            SceneManager.LoadScene("MainScene");
            Debug.Log("stagenext");
            isStageNext = true;
        });

        tutorialNextButton.onClick.AddListener(() => // 클리어하고 메인화면으로 돌아감
        {         
            SceneManager.LoadScene("MainScene");
            Debug.Log("tutorialnext");
            isTutorialNext = true;        
        });


        if (UIManager.isTutorial == true)
        {
            if(UIManager.isVideoplay == true)
            {
                videoscreen.gameObject.SetActive(true);
                video.Play();

                skipButton.onClick.AddListener(() =>
                {
                    /*videoscreen.gameObject.SetActive(false);
                    video.Stop();*/

                    SceneManager.LoadScene("MainScene");
                });
            }
             
            start_text.text = "리듬에 맞춰 터치하세요";
            Instantiate(Stage[0]);
        }
        if(UIManager.isStage == true)
        {
            
            start_text.text = "Start";

            if (UIManager.isStage_1 == true)
            {
                
                Instantiate(Stage[1]);
            }
            if (UIManager.isStage_2 == true)
            {
                Instantiate(Stage[2]);
            }
            if (UIManager.isStage_3 == true)
            {
                Instantiate(Stage[3]);
            }
            if (UIManager.isStage_4 == true)
            {
                Instantiate(Stage[4]);
            }
        }
      
    }   
}
