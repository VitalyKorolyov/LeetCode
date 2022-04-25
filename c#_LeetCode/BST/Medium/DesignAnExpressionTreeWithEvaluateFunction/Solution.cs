using System;
using System.Collections.Generic;

namespace LeetCode.BST.Medium.DesignAnExpressionTreeWithEvaluateFunction
{
    //https://leetcode.com/problems/design-an-expression-tree-with-evaluate-function/
    public abstract class Node
    {
        public abstract int evaluate();
    };

    public class TreeNode : Node
    {
        public override int evaluate() => Value;
        public int Value { get; set; }
    }

    public class OperationNode : Node
    {
        public override int evaluate()
        {
            var left = Left.evaluate();
            var right = Right.evaluate();

            return Operation switch
            {
                "+" => left + right,
                "-" => left - right,
                "*" => left * right,
                "/" => left / right,
                _ => throw new NotImplementedException()
            };
        }

        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class TreeBuilder
    {
        private static HashSet<string> operations = new HashSet<string> {"+", "-", "/", "*" };

        public Node buildTree(string[] postfix)
        {
            var stack = new Stack<Node>();

            for (int i = 0; i < postfix.Length; i++)
            {
                if (operations.Contains(postfix[i]))
                {
                    var operNode = new OperationNode { Operation = postfix[i]};
                    
                    operNode.Right = stack.Count > 0 ? stack.Pop() : null;
                    operNode.Left = stack.Count > 0 ? stack.Pop() : null;

                    stack.Push(operNode);
                }
                else
                {
                    stack.Push(new TreeNode { Value = int.Parse(postfix[i]) });
                }
            }

            return stack.Pop();
        }
    }
}
