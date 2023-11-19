using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDestinationDirector : MonoBehaviour
{
    [SerializeField]
    public List<npcDestinations> roomNumber;

    [System.Serializable]
    public class npcDestinations{
        [SerializeField]
         public List<objectStorage> gameObjectLocations;

         [System.Serializable]
         public class objectStorage{
            public  GameObject currentDestination;
         }
    }
}
