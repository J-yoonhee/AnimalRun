using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public Button[] lvButtons; // 스테이지 버튼을 리스트로 관리

    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2); // int default값이 2이면 스테이지 1은 기본으로 값을 가져온다. 왜냐하면 build setting에 저장된 스테이지 1의 값이 2이기 때문이다.

        for (int i = 0; i < lvButtons.Length; i++) // 0 ~ 3까지 반복문을 실행
        {
            if (i + 2 > levelAt) // levelAt이 2미만이면 버튼클릭을 비활성화  {levelAt의 스테이지가 1이면 스테이지2는 비활성화}
            {
                lvButtons[i].interactable = false;
            }
        }
    }

}
