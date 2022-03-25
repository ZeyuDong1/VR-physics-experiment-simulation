using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class CalcOperation
    {
        /// <summary>
        /// 计算字符串解析表达式 1+2(2*(3+4))
        /// </summary>
        /// <param name="str">传入的字符串</param>
        /// <returns>计算得到的结果</returns>
        public decimal CalcStr(string str)
        {
            decimal num = 0m;
            //数字集合
            List<decimal> numList = new List<decimal>();
            //操作符集合
            List<Operation> operList = new List<Operation>();
            string strNum = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                //判断如果是数字和.
                if ((47 < c && c < 58) || c == '.')
                {
                    strNum += c;

                    if (i == str.Length - 1)
                    {
                        if (!string.IsNullOrEmpty(strNum))
                        {
                            decimal.TryParse(strNum, out num);
                            numList.Add(num);
                            strNum = "";
                        }
                    }
                    continue;
                }
                else if (c == '(')
                {
                    int temp = 1;
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        var k = str[j];
                        if (k == '(')
                        {
                            temp++;
                        }
                        else if (k == ')')
                        {
                            temp--;
                        }

                        if (temp == 0)
                        {
                            temp = j - i - 1;
                        }
                    }

                    strNum = str.Substring(i + 1, temp);
                    numList.Add(CalcStr(strNum));
                    strNum = "";
                    i += temp + 1;
                }
                else
                {
                    if (!string.IsNullOrEmpty(strNum))
                    {
                        decimal.TryParse(strNum, out num);
                        numList.Add(num);
                        strNum = "";
                    }

                    if (c == '+')
                    {
                        operList.Add(new AddOperation());
                    }
                    else if (c == '-')
                    {
                        operList.Add(new SubOperation());
                    }
                    else if (c == '*')
                    {
                        operList.Add(new MultipOperation());
                    }
                    else if (c == '/')
                    {
                        operList.Add(new DivOperation());
                    }
                    else if (c == '%')
                    {
                        operList.Add(new ModOperation());
                    }
                    else
                    {
                        operList.Add(null);
                    }
                }
            }

            List<int> tempOrder = new List<int>();
            operList.ForEach(w =>
            {
                if (!tempOrder.Contains(w.PrioRity))
                {
                    tempOrder.Add(w.PrioRity);
                }

            });

            tempOrder.Sort();
            for (int t = 0; t < tempOrder.Count; t++)
            {
                for (int i = 0; i < operList.Count; i++)
                {
                    if (operList[i].PrioRity == tempOrder[t])
                    {
                        numList[i] = operList[i].OperationResult(numList[i], numList[i + 1]);
                        numList.RemoveAt(i + 1);
                        operList.RemoveAt(i);
                        i--;
                    }
                }
            }

            if (numList.Count == 1) return numList[0];

            return 0m;
        }

        public class Operation
        {
            protected int priority = 99;
            /// <summary>
            /// 优先级
            /// </summary>
            public virtual int PrioRity
            {
                get
                {
                    return priority;
                }
                set
                {
                    priority = value;
                }
            }

            public virtual decimal OperationResult(decimal a, decimal b)
            {
                return 0m;
            }
        }

        public class AddOperation : Operation
        {
            public override decimal OperationResult(decimal a, decimal b)
            {
                return a + b;
            }
        }

        public class SubOperation : Operation
        {
            public override decimal OperationResult(decimal a, decimal b)
            {
                return a - b;
            }
        }

        public class MultipOperation : Operation
        {
            public override int PrioRity
            {
                get
                {
                    return 98;
                }
            }

            public override decimal OperationResult(decimal a, decimal b)
            {
                return a * b;
            }
        }

        public class DivOperation : Operation
        {
            public override int PrioRity
            {
                get
                {
                    return 98;
                }
            }
            public override decimal OperationResult(decimal a, decimal b)
            {
                return a / b;
            }
        }

        public class ModOperation : Operation
        {
            public override int PrioRity
            {
                get
                {
                    return 97;
                }
            }
            public override decimal OperationResult(decimal a, decimal b)
            {
                return a % b;
            }
        }

    }
}