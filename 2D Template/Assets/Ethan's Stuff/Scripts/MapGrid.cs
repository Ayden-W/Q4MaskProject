using UnityEngine;

public class MapGrid : MonoBehaviour
{

    public GameObject node;
    private int randomInt;
    private int randomInt2;
    private int nodePosition;
    private Vector3 randomPosition;
    private Vector3 randomPosition2;
    private float originalX;
 
    
    private void Awake()
    {
       

        for (int i = 0; i < 10; i++)
        {
            
            randomInt = Random.Range(-4, 4);
            randomInt2 = Random.Range(-4, 4);// Minimum and Maximum of Y 
            randomPosition = new Vector2(-2 + randomPosition.x + 1, randomInt);
            randomPosition2 = new Vector2(-2 + randomPosition2.x + 1, randomInt2);
            Instantiate(node, randomPosition, node.transform.rotation);
            Instantiate(node, randomPosition2, node.transform.rotation);

            /*LineRenderer lr = FindFirstObjectByType<LineRenderer>();*/ // Grabs the LineRenderer
            LineRenderer lr = FindFirstObjectByType<LineRenderer>();

            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount-1, randomPosition);
            lr.positionCount++;   //Sets line for LineRenderer
            lr.SetPosition(lr.positionCount - 1, randomPosition2);

        }
    }






  
    



   
    

}
