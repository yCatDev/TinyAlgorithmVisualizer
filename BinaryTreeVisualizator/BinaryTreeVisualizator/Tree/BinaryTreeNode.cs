﻿using System;

namespace BinaryTreeVisualizator.Tree
{
    public enum Side
    {
        Left = -1,
        Root = 0,
        Right = 1
    };
    
    public class BinaryTreeNode<T> : IComparable<T>
        where T : IComparable
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }
 
        public BinaryTreeNode<T> Parent { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public T Value { get; private set; }
        public int Index {get; set; }
        public Side Side { get; set; } 
 
        /// 
        /// Сравнивает текущий узел с данным.
        /// 
        /// Сравнение производится по полю Value.
        /// Метод возвращает 1, если значение текущего узла больше,
        /// чем переданного методу, -1, если меньше и 0, если они равны
        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
        
    }
}