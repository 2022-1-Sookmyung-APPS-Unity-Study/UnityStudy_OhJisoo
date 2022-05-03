using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            float rand = Random.Range(0.0f, 0.5f); //0.0에서 0.5사이의 랜덤한 숫자 rand에 대입
            this.transform.position = new Vector3(0.0f, 1.0f, rand);
            //position = 절대적인 위치 절대적인 좌표값이라고 생각하면 될듯..?
            //this = 스크립트가 적용된 오브젝트
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            float rand = Random.Range(0.0f, 360.0f);
            this.transform.rotation = Quaternion.Euler(rand, 0, 0f);
            //this.transform.rotaton = 오브젝트의 회전 각도 나타냄
            //Quaternion.Euler = ? 무슨 뜻인지 다시 확인
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
        }
        //Translate:상대적인 위치 . 지금 위치한 곳에서 얼마나 이동할 것인지 설정가능.
        //다른 컴퓨터에서도 시간에 따라 동일한 거리를 이동시키기위해 Time.deltaTime 사용함.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * 2.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))  //자회전
        {
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.L))  //우회전
        {
            this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            float rand = Random.Range(0.5f, 2.0f);
            this.transform.localScale = new Vector3(rand, rand, rand);
        }



    }
}
