using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Gameplay.Player
{
    public class Controller : MonoBehaviour
    {
        private void Awake()
        {
            this.UpdateAsObservable()
                .Select(_ => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")))
                .Subscribe(f => { transform.position += new Vector3(f.x, 0, f.y) * Time.deltaTime * 10; });
        }
    }
}