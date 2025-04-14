using UnityEngine;

public class MapGrid : MonoBehaviour
{

    public GameObject node;
    private int randomInt;
    private int nodePosition;
    private Vector3 randomPosition;
    private float originalX;
 

    private void Awake()
    {

        for (int i = 0; i < 10; i++)
        {

            randomInt = Random.Range(1, 13);
            randomPosition = new Vector2(randomPosition.x + 1, randomInt);
            Instantiate(node, randomPosition, node.transform.rotation);
        }
    }






  
    



   
    

}
