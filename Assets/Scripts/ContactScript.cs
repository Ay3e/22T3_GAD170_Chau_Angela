using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{ 
    public enum ContactEnum {Undefined, A, B, C}

    public class ContactScript : MonoBehaviour
    {
        [SerializeField] private ContactEnum chosenContact = ContactEnum.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string lastName;
        [SerializeField] private string preferredName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            switch (chosenContact)
            {
                case ContactEnum.Undefined:
                    Debug.Log("Contact undefined. Set its enum in the inspector before you play");
                    break;
                case ContactEnum.A:
                    SetupContact("A", "a", "AA", "1111 111 111", "1 AAA St", "Aa@gmail.com");
                    break;
                case ContactEnum.B:
                    SetupContact("B", "b", "BB", "2222 222 222", "2 BBB Rd", "Bb@gmail.com");
                    break;
                case ContactEnum.C:
                    SetupContact("C", "c", "CC", "3333 333 333", "3 CCC Cr", "Cc@gmail.com");
                    break;
                default:
                    Debug.Log("Invalid choice");
                    break;
            }
        }
        private void SetupContact(string newFirstName,
                                  string newLastName,
                                  string newPreferredName,
                                  string newPhoneNumber,
                                  string newAddress,
                                  string newEmail)
        {
            firstName = newFirstName;
            lastName = newLastName;
            preferredName = newPreferredName;
            phoneNumber = newPhoneNumber;
            address = newAddress;
            email = newEmail;
        }
    }
}