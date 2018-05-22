using System;

namespace TodoApi.Interfaces
{
    public interface IOperation
    {
        // string OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }
    public interface IOperationScoped : IOperation
    {
    }
    public interface IOperationSingleton : IOperation
    {
    }
    public interface IOperationSingletonInstance : IOperation
    {
    }

    public class Operation : IOperation, IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Guid OperationId { get; set; }
        public Operation()
        {
            OperationId = Guid.NewGuid();
            Console.WriteLine(OperationId);
        }

        // public string OperationId { get; set; }
    }
}