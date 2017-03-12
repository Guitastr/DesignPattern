using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    /// <summary>
    /// 没有命令，空对象，在许多设计模式中，都会看到空对象的使用，
    /// 甚至有些时候，空对象本身也被视为是一种设计模式；
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log("NoCommand");
        }

        public void Undo()
        {
            Debug.Log("NoCommand");
        }
    }
}