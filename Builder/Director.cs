using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public Dog Construct(IBuilder builder) 
        {
            if (builder.GetColor() == null)
            {
                builder.SetColor("white");
            }
            if (builder.GetName() == null)
            {
                builder.SetName("Default name");
            }
            return builder.Build();
        }
    }
}
