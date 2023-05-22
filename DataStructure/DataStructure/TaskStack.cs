﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class TaskStack<T> : SinglyLinkedList<T>
    {
        public void Push(T Rvalue)
        {
            var node = new SinglyNode<T>() { Tvalue = Rvalue };
            node.nextNode = nodeHead;
            nodeHead = node;
        }


    }
}
