using UnityEngine;

public class DetectNode : MonoBehaviour
{
    
    MeshRenderer Render;
    private bool inRange;
    Sensor sensor;
    void Start()
    {
        
        sensor = GetComponent<Sensor>();
       
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (sensor.isDetecting)
    //    {
    //        inRange = true;
    //    }
    //    else
    //    {
    //        inRange = false;
    //    }
    //}
}
