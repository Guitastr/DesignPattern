namespace Assets.Scripts.CommandPattern.Example_02
{
    /// <summary>
    /// 没有命令
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}