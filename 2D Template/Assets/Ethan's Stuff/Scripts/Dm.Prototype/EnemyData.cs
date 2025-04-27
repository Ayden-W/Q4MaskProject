using UnityEngine;

[System.Serializable]
public class EnemyData
{

        public int _EH;
        public int _EHM;
    public int _EDMG;

        public EnemyData(EnemyData Enemy)
        {
            //_EH = Enemy._EH;
            //_EHM = Enemy._EHM;
            _EH = Enemy._EH;
            _EHM = Enemy._EHM;
            _EDMG = Enemy._EDMG;
        }

   
}
