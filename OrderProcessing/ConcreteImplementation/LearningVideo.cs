using OrderProcessing.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ConcreteImplementation
{

    //concrete Learning Video
    public class LearningVideo : PhysicalProduct
    {

        public override void Run()
        {
            base.GenerateSlip();
            Console.WriteLine("Add First Aid Video");
        }
    }
}
