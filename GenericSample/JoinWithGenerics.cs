using System;

namespace GenericSample
{
    public class JoinWithGenerics<T>
    {
        public T JoinMethod(dynamic GenericParam1, dynamic GenericParam2)
        {
            var x = GenericParam1 + GenericParam2;
            Console.WriteLine(x);
            return x;
        }
    }
}
