using System;

public interface Command
{
    /// <summary>
    ///     执行
    /// </summary>
    void Execute();


    void Undo();
}