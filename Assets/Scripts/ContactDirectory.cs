using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{

    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<ContactScript> contactsList = new List<ContactScript>();
        private void Start()
        {
            for (int i=0; i<contactsList.Count; i++)
            {
                contactsList[i].Initialise();
            }
        }
    }
}