namespace Assets.Scripts.CommandPattern.Example_02
{
    public interface ICommand
    {
        /// <summary>
        ///     执行
        /// </summary>
        void Execute();

        /// <summary>
        ///     撤销
        /// </summary>
        void Undo();
    }
}