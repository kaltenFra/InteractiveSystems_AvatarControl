using UnityEngine;

namespace DitzelGames.FastIK
{
    public class SampleRotator : MonoBehaviour
    {
        
        void Update()
        {
            //just rotate the object
            transform.Rotate(5, Time.deltaTime * -90, 0);
        }
    }
}
