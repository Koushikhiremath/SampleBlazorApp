using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Client.Sample
{
    public class SampleBase : ComponentBase
    {
        protected int count = 0;

        protected void IncreaseCount()
        {
            count++;
        }

    }
}
