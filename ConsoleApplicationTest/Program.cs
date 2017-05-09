using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dd = new TridentResult<object>();
            if (!Equals(dd.DataResult, null))
            {
            }

        }
        public class TridentResult<T> 
        {
            /// <summary>
            /// 返回结果
            /// </summary>
            public T DataResult
            {
                get;
                set;
            }
        }
    }
}
