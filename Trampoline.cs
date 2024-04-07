using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10; // Устанавливает силу прыжка на 10
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2; // Устанавливает силу прыжка на 2
    }
}
