using Patterns.Interfaces;
using System;

namespace Patterns.PatternsSources
{
    public class Factory : IPattern
    {
        public void InitalizePattern()
        {
            GadgetFactory factory;

            factory = new TabletFactory();
            Gadget tablet = factory.Create();
            Console.WriteLine(tablet.ToString());

            factory = new LaptopFactory();
            Gadget laptop = factory.Create();
            Console.WriteLine(laptop.ToString());

            factory = new CellPhoneFactory();
            Gadget cellPhone = factory.Create();
            Console.WriteLine(cellPhone.ToString());

            Console.ReadLine();
        }

        abstract class GadgetFactory
        {
            abstract public Gadget Create();
        }
        class TabletFactory : GadgetFactory
        {
            public override Gadget Create()
            {
                return new Tablet();
            }
        }
        class LaptopFactory : GadgetFactory
        {
            public override Gadget Create()
            {
                return new Laptop();
            }
        }

        class CellPhoneFactory : GadgetFactory
        {
            public override Gadget Create()
            {
                return new CellPhone();
            }
        }

        abstract class Gadget
        { }

        class Tablet : Gadget
        {
            public override string ToString()
            {
                return "Tablet";
            }
        }
        class CellPhone : Gadget
        {
            public override string ToString()
            {
                return "CellPhone";
            }
        }
        class Laptop : Gadget
        {
            public override string ToString()
            {
                return "Laptop";
            }
        }
    }
}
