using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    public unsafe struct XORLinkedList
    {
        static XorNode* Add(XorNode* val, int data = 0) {
            var node = (XorNode*)Marshal.AllocHGlobal(sizeof(XorNode));
            node->Next = val;
            node->Data = data;//point to data
            return node;
        }

        static XorNode* Get(XorNode* head)
        {
            XorNode* node = head;
            XorNode* prev = null;
            XorNode* next = head->Next;
            while(node != null)
            {
                next = node->Next;
                node->Next = PtrXor(prev, next);
                prev = node;
                node = next;
            }
            //implement
            return node;
        }
    
        private static unsafe XorNode* PtrXor(XorNode* a, XorNode* b)
        {
            return (XorNode*)((ulong)a ^ (ulong)b);
        }
    
    }

    unsafe struct XorNode
    {
        public int Data { get; set; }
        public unsafe XorNode* Next { get; set; }

        public XorNode(int data)
        {
            Data= data;
            Next = null;
        }
    }

}

//An XOR linked list is a more memory efficient doubly linked list.
//Instead of each node holding next and prev fields, it holds a field named both,
//which is an XOR of the next node and the previous node. Implement an XOR linked list;
//it has an add(element) which adds the element to the end, and a get(index) which returns the node at index.

//If using a language that has no pointers (such as Python), you can assume you have access
//    to get_pointer and dereference_pointer functions that converts between nodes and memory addresses.
//Marshal.AllocHGGlobal == malloc