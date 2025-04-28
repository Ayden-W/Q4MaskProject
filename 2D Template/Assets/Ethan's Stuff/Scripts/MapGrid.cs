using Unity.VisualScripting;
using UnityEngine;

public class MapGrid : MonoBehaviour
{

    public GameObject node;
    private float randomInt;
    private float randomInt2;
    private GameObject CurrentNode;
    private Vector3 randomPosition;
    private Vector3 randomPosition2;
    private float originalX;
    public float min;
    public float max;
    public float xSpacing;
    private bool inRange;
    Sensor sensor;
    DetectNode detectNode;
    public GameObject nodeGroup;
    public Sprite[] Icons;
    private void Awake()
    {
        sensor = GetComponent<Sensor>();

        for (int i = 0; i < 10; i++)
        {
            
            randomInt = Random.Range(min, max);
            randomInt2 = Random.Range(min, max);// Minimum and Maximum of Y 
            randomPosition = new Vector2(randomPosition.x + xSpacing, randomInt);
            randomPosition2 = new Vector2(randomPosition2.x + xSpacing, randomInt2);

            GameObject nodeListGo = Instantiate(node, randomPosition + Vector3.left * 1, node.transform.rotation);
            GameObject Nodelist2Go = Instantiate(node, randomPosition2 + Vector3.left * 1, node.transform.rotation);

            nodeListGo.transform.SetParent(nodeGroup.transform, true);
            Nodelist2Go.transform.SetParent(nodeGroup.transform, true);

            NodeList nodeList;
            NodeList nodeList2;

            int r = Random.Range(0, 10);
            if (r == 0)
            {
                nodeList=nodeListGo.AddComponent<Heal>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[2];
                nodeList2= Nodelist2Go.AddComponent<Heal>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[2];
            }
            else if (r  == 1)
            {
                nodeList =nodeListGo.AddComponent<Shop>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[1];
                nodeList2 = Nodelist2Go.AddComponent<Shop>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[1];
            }
            else if (r == 2)
            {
                nodeList = nodeListGo.AddComponent<BossFight>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[3];
                nodeList2 = Nodelist2Go.AddComponent<BossFight>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[3];
            }
            else if (r == 3)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[0];
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[0];
            }
            else if (r == 4)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[0];
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[0];
            }
            else if (r == 5)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[0];
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[0];
            }
            else if (r == 6)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[0];
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[0];
            }
            else if (r == 7)
            {
                nodeList = nodeListGo.AddComponent<Heal>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[2];
                nodeList2 = Nodelist2Go.AddComponent<Heal>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[2];
            }   
            else if (r ==8)
            {
                nodeList = nodeListGo.AddComponent<Heal>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[2];
                nodeList2 = Nodelist2Go.AddComponent<Heal>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[2];
            }
            else
            {
                nodeList = nodeListGo.AddComponent<Shop>();
                nodeList.GetComponent<SpriteRenderer>().sprite = Icons[1];
                nodeList2 = Nodelist2Go.AddComponent<Shop>();
                nodeList2.GetComponent<SpriteRenderer>().sprite = Icons[1];
            }

            /*LineRenderer lr = FindFirstObjectByType<LineRenderer>();*/ // Grabs the LineRenderer
            LineRenderer lr = FindFirstObjectByType<LineRenderer>();


            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount-1, nodeList.transform.position);
            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount - 1, nodeList2.transform.position);

        }

        node.AddComponent<EmptyNode>();

        for (int i = 0; i< nodeGroup.transform.childCount - 1; i++)
        {
            nodeGroup.transform.GetChild(i).GetComponent<NodeList>().Next = nodeGroup.transform.GetChild(i + 1).GetComponent<NodeList>();
        }


    }






  
    



   
    

}
