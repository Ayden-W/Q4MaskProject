using UnityEngine;

public class Grid_Test : MonoBehaviour
{
   public int height;
   public int length;

    bool[,] grid;

    public void Init(int length, int height)
    {
        grid = new bool[length, height];
        this.length = length;
        this.height = height;
    }

    public void Set(int x, int y, bool to)
    {
        
        
            if (CheckPosition(x,y) == false) 
            { 
                
                Debug.LogWarning("Ha, Idiot" + x.ToString() + ": " + y.ToString());
                return;
            }

        grid[x, y] = to;
    }

    public bool Get(int x, int y)
    {
        
        
            if (CheckPosition(x, y) == false) 
            {
                Debug.LogWarning("Ha, Idiot" + x.ToString() + ": " + y.ToString());
                 return false;
            }
            
            
             
        
        return grid[x, y];
    }

    public bool CheckPosition(int x, int y)
    {
        if (x < 0 || x >= length )
        {
            return false;
        }

        if (y < 0 || y >= height)
        {
            return false;
        }

        return true;
    }
}
