using Unity.VisualScripting;
using UnityEngine;

public class MapGrid : MonoBehaviour
{

    public GameObject node;
    private float randomInt;
    private float randomInt2;
    private int nodePosition;
    private Vector3 randomPosition;
    private Vector3 randomPosition2;
    private float originalX;
    public float min;
    public float max;
    public float xSpacing;
    
    private void Awake()
    {
       

        for (int i = 0; i < 10; i++)
        {
            
            randomInt = Random.Range(min, max);
            randomInt2 = Random.Range(min, max);// Minimum and Maximum of Y 
            randomPosition = new Vector2(randomPosition.x + xSpacing, randomInt);
            randomPosition2 = new Vector2(randomPosition2.x + xSpacing, randomInt2);

            GameObject nodeListGo = Instantiate(node, randomPosition + Vector3.left * 1, node.transform.rotation);
            GameObject Nodelist2Go = Instantiate(node, randomPosition2 + Vector3.left * 1, node.transform.rotation);

            NodeList nodeList;
            NodeList nodeList2;

            int r = Random.Range(0, 10);
            if (r == 0)
            {
                nodeList=nodeListGo.AddComponent<Heal>();
                nodeList2= Nodelist2Go.AddComponent<Heal>();
            }
            else if (r  == 1)
            {
                nodeList =nodeListGo.AddComponent<Shop>();
                nodeList2 = Nodelist2Go.AddComponent<Shop>();
            }
            else if (r == 2)
            {
                nodeList = nodeListGo.AddComponent<BossFight>();
                nodeList2 = Nodelist2Go.AddComponent<BossFight>();
            }
            else if (r == 3)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
            }
            else if (r == 4)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
            }
            else if (r == 5)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
            }
            else if (r == 6)
            {
                nodeList = nodeListGo.AddComponent<Fight>();
                nodeList2 = Nodelist2Go.AddComponent<Fight>();
            }
            else if (r == 7)
            {
                nodeList = nodeListGo.AddComponent<Heal>();
                nodeList2 = Nodelist2Go.AddComponent<Heal>();
            }   
            else if (r ==8)
            {
                nodeList = nodeListGo.AddComponent<Heal>();
                nodeList2 = Nodelist2Go.AddComponent<Heal>();
            }
            else
            {
                nodeList = nodeListGo.AddComponent<Shop>();
                nodeList2 = Nodelist2Go.AddComponent<Shop>();
            }

                /*LineRenderer lr = FindFirstObjectByType<LineRenderer>();*/ // Grabs the LineRenderer
                LineRenderer lr = FindFirstObjectByType<LineRenderer>();

            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount-1, nodeList.transform.position);
            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount - 1, nodeList2.transform.position);

        }
    }






  
    



   
    

}
