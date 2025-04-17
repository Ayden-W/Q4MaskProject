using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class lineController : MonoBehaviour
{

    private LineRenderer lr;
    private Transform[] points;
    

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        
    }

    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;

        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
