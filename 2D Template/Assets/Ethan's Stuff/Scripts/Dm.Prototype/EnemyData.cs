using UnityEngine;

[System.Serializable]
public class EnemyData
{
   
        public int _EH;
        public int _EHM;

        public EnemyData(EnemyData EnemyHealth)
        {
            _EH = EnemyHealth._EH;
            _EHM = EnemyHealth._EHM;

        }

   
}
