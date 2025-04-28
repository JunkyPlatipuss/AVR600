using UnityEngine;
using UnityEngine.Events;

public class playerCollection : MonoBehaviour
{
    public int acornCount {get; private set;}
    public UnityEvent<playerCollection> onAcornCollected;
    public void acornCollected() {
        acornCount++;
        onAcornCollected.Invoke(this);
    }
}
