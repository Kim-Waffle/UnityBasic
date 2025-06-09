using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    // 천장 시스템 카운트 설정
    int count;
    private void Awake()
    {
        count = 1; // 카운트 초기화
    }

    public void Gatcha()

    {
        int number = 1;
        while (number <= 10)
        {
            int randomValue = Random.Range(1, 101); // 1에서 101미만의 랜덤한 값 생성

            // 확률이 10%면 로그에 '각청'을 뽑았다!
            // 확률이 20%면 로그에 '모나'를 뽑았다!
            // 나머지 70% 확률로 '치치'를 뽈아버렸다!

            Debug.Log($"{number}회차 랜덤한 값은 {randomValue} 입니다");

            if (count >= 8)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0; // 천장 획득 후 카운트 초기화
            }

            else if (randomValue >= 91)
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue >= 71)
            {
                Debug.Log("'모나'를 뽑았다!");
            }
            else
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }

            count++;

            number++;
        }

    }

    //public int selectNumber = 0;

    //public void GatchaSwitch()
    //{
    //    int randomValue = Random.Range(1, 101); // 1에서 101미만의 랜덤한 값 생성

    //    // 확률이 10%면 로그에 '각청'을 뽑았다!
    //    // 확률이 20%면 로그에 '모나'를 뽑았다!
    //    // 나머지 70%확률로 '치치'를 뽈아버렸다!

    //    switch (selectNumber)
    //    {
    //        case 0:
    //            // 은색 머리 캐릭터가 나온다
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    // 픽업 캐릭 : 이번 뽑기에 확률이 높게  설정되는 캐릭터
    //                    // 유저들이 특정 캐릭터를 목표하고 뽑게 만드는 시스템
    //                    Debug.Log("'은색 머리'을 뽑았다!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'모나'을 뽑았다!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'치치'를 뽑아버렸다!");
    //                }
    //            }
    //            break;

    //        case 1:
    //            // 파란 머리 캐릭터가 나온다
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'파란 머리'을 뽑았다!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'모나'을 뽑았다!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'치치'를 뽑아버렸다!");
    //                }
    //            }
    //            break;

    //        case 2:
    //            // 분홍 머리 캐릭터가 나온다
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'분홍 머리'을 뽑았다!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'모나'을 뽑았다!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'치치'를 뽑아버렸다!");
    //                }
    //            }
    //            break;

    //        default:
    //            // 파란 머리 꼬마 캐릭터가 나온다.
    //            {
    //                if (randomValue <= 10) // 1 ~ 10 -> 10%
    //                {
    //                    Debug.Log("'파란 머리 꼬마'을 뽑았다!");
    //                }
    //                else if (randomValue <= 30) // 11 ~ 30
    //                {
    //                    Debug.Log("'모나'을 뽑았다!");
    //                }
    //                else
    //                {
    //                    Debug.Log("'치치'를 뽑아버렸다!");
    //                }
    //            }
    //            break;
    //    }
    //}

    //int count;

    //private void Awake()
    //{
    //    count = 0;
    //}

    //private void Start()
    //{
    //   for(int i = 0; i < 5; i++)
    //   {
    //        Debug.Log("반복문이 실행됐어요~:)");
    //   }

    // Update is called once per frame
    void Update()
    {

    }
}
