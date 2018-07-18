using _01.Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Models.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            ILayout layout = null;
            switch (layoutType)
            {
                case"SimpleLayout":
                    layout = new SimpleLayout();
                    break;
                case "XmlLayout":
                    layout = new XmlLayout();
                    break;
                default:
                    throw new ArgumentException("Invalid Layout Type");
            }
            return layout;
        }
    }
}
