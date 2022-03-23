using UnityEngine;

namespace Ability
{
    public class Ability : ScriptableObject
    {
        public new string name;
        public float cooldownTime;
        public float activeTime;
        
        public virtual void Activate(GameObject parent){}
        public virtual void BeginCoolDown(GameObject parent){}
    }
}
