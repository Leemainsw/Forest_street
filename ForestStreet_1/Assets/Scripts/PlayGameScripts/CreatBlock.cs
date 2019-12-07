using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBlock : MonoBehaviour
{
    public float moveSpeed; //움직이는 속도
    public float MIN = -1096, MAX = 1178;

    public GameObject BlockRed;
    public GameObject BlockBlue;
    public GameObject BlockYellow;

    //부모 위치
    public Transform PBlockRed; 
    public Transform PBlockBlue;
    public Transform PBlockYellow;

    public GameObject Exit_Canvas;

    Vector3[] pos = new Vector3[300]; //랜덤생성된 블록의 초기 위치 값 저장.

    private GameObject[] BlockClone = new GameObject[300]; //랜덤 생성된 블록

    int YellowCount = 0; //yellow 블럭 개수 제한

    // Start is called before the first frame update
    void Start()
    {
        CreateBlocks(); //블록 생성
    }

    // Update is called once per frame
    void Update()
    {
        if (BackGroundScroll.time < 0.0f)
        {
            BlockStart(BlockClone[0]); //첫 번째 Block 출발

            for (int i = 1; i< 300; i++)
            {

                if (BlockClone[i-1].transform.position.x <= pos[i-1].x - BlockClone[i - 1].transform.GetComponent<RectTransform>().rect.width)
                {
                    BlockStart(BlockClone[i]);
                }

            }

        }

    }

    void BlockStart(GameObject BlockClone)
    {
        if (Exit_Canvas.activeSelf != true)
        BlockClone.transform.position -= new Vector3(moveSpeed * 2 * Time.deltaTime, 0, 0);
    }

    void CreateBlocks()
    {
        
       for (int i = 0; i< 300; i++) //block 랜덤 생성
        {
            Debug.Log("for문" + i + "시작");

            int random = Random.Range(0, 3);
            if (YellowCount > 80) { random = Random.Range(0, 2); }//yellow 100개 중 80개로 개수 제한
            switch (random)
            { 
                case 0:
                    {
                        Debug.Log("case1");
                        BlockClone[i] = Instantiate(BlockRed) as GameObject;
                        BlockClone[i].transform.SetParent(PBlockRed);
                        BlockClone[i].transform.position = PBlockRed.transform.position;
                        BlockClone[i].tag = "Red";
                        break;
                    }
                case 1:
                    {
                        Debug.Log("case2");
                        BlockClone[i] = Instantiate(BlockBlue) as GameObject;
                        BlockClone[i].transform.SetParent(PBlockBlue);
                        BlockClone[i].transform.position = PBlockBlue.transform.position;
                        BlockClone[i].tag = "Blue";
                        break;
                    }
                case 2:
                    {
                        Debug.Log("case3");
                        BlockClone[i] = Instantiate(BlockYellow) as GameObject;
                        BlockClone[i].transform.SetParent(PBlockYellow);
                        BlockClone[i].transform.position = PBlockYellow.transform.position;
                        BlockClone[i].tag = "Yellow";
                        YellowCount++;
                        break;
                    }

            }
            pos[i] = BlockClone[i].transform.position;
            random = 0;
            Debug.Log("for문" + i + "끝");

        }
    }
}
   
