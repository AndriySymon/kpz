﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHTML => Text;
        public override string InnerHTML => Text;

        public override ILightNodeIterator GetDepthFirstIterator()
        {
            return new DepthFirstIterator(this);
        }

        public override ILightNodeIterator GetBreadthFirstIterator()
        {
            return new BreadthFirstIterator(this);
        }
        public override void Accept(IElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
