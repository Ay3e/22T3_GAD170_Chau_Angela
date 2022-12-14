using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{
    public class TemperatureChecker : MonoBehaviour
    {
        [SerializeField] private float currentPorridgeTemperature = 85.0f;

        private float hotLimitTemperature = 70f;
        private float coldLimitTemperature = 40f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TemperatureTest();
            }
            currentPorridgeTemperature -= Time.deltaTime * 5f;
        }

        void TemperatureTest()
        {
            if (currentPorridgeTemperature > hotLimitTemperature)
            {
                Debug.Log("The porridge is too hot " + (int)currentPorridgeTemperature + " Degree Celsius");
            }
            else if (currentPorridgeTemperature < coldLimitTemperature)
            {
                Debug.Log("The porridge is too cold " + (int)currentPorridgeTemperature + " Degree Celsius");
            }
            else if (currentPorridgeTemperature == 55f)
            {
                Debug.Log("The porridge is exactly 55C" + (int)currentPorridgeTemperature + "Degree Celsius");
            }
            else
            {
                Debug.Log("The porridge is just right. " + (int)currentPorridgeTemperature + " Degree Celsius");
            }
        }
    }
}