﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayProject
{
    class QueueA
    {
        private int[] queueArray;
        private int rear;
        private int front;
        public QueueA()
        {
            queueArray = new int[10];
            rear = -1;
            front = -1;
        }
        public QueueA(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }
        public bool IsEmpty()
        {
            return (front == -1 || front == rear + 1);
        }
        public bool IsFull()
        {
            return (rear == queueArray.Length - 1);
        }
        public int Size()
        {
            if (IsEmpty())
                return 0;
            else
                return rear - front + 1;
        }
        public void Insert(int x)
        {
            if (IsFull())
            {
                Console.WriteLine(" queue is Overflow");
                return;
            }
            if (front == -1)
                front = 0;
            rear = rear + 1;
            queueArray[rear] = x;
        }
        public int Delete()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("underflow");
            x = queueArray[front];
            front = front + 1;
            return x;  
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Queue is :\n\n");
            for(int i = front; i <= rear; i++)
            {
                Console.Write(queueArray[i] + " ");
            }
            Console.WriteLine();
        }
        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("underflow");
            return queueArray[front];
        }
    }
}
