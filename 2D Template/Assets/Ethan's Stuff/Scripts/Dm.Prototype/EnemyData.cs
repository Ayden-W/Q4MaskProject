using UnityEngine;

[System.Serializable]
public class EnemyData
{

        public int _EH = 100;
        public int _EHM = 100;

        public EnemyData(EnemyData Enemy)
        {
            //_EH = Enemy._EH;
            //_EHM = Enemy._EHM;
            _EH = Enemy._EH;
            _EHM = Enemy._EHM;
    }

   
}
