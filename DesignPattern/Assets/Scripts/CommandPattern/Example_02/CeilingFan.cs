using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    public class CeilingFan
    {
        private readonly string _name;

        public CeilingFan(string name)
        {
            _name = name;
        }

        public void On()
        {
            Debug.Log(_name + " CeilingFan is On");
        }

        public void Off()
        {
            Debug.Log(_name + " CeilingFan is Off");
        }
    }
}