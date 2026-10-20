using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);//เอาออก
 
            int count = stack.Count;
            Debug.Log($"Count: {count}");
            int popped = stack.Pop();//3
            Debug.Log($"Popped: {popped}");
            int peek = stack.Peek();
            Debug.Log($"Peek: {peek}");
            int countAfterPeek = stack.Count;
            Debug.Log($"CountAfterPeek: {countAfterPeek}");
 
            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);//เอา 1 ออก
            queue.Enqueue(2);
            queue.Enqueue(3);
 
            int count = queue.Count;
            Debug.Log($"Count: {count}");
            int dequeued = queue.Dequeue();
            Debug.Log($"Dequeued: {dequeued}");
            int peek = queue.Peek();
            Debug.Log($"Peek: {peek}");
            int countAfterPeek = queue.Count;
            Debug.Log($"CountAfterPeek: {countAfterPeek}");
 
            return(count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
     
            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            string[] poppedName = new string[stack.Count];
            for (int i = 0; i < poppedName.Length; i++) { 
                var popped = stack.Pop();
                poppedName[i] = popped.Name;
                Debug.Log($"Popped: {poppedName[i]}");
            }

            return(poppedName);
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            string[] dequeneedName = new string[queue.Count];
            for (int i = 0; i < dequeneedName.Length; i++)
            {
                var dequeneed = queue.Dequeue();
                dequeneedName[i] = dequeneed.Name;
                Debug.Log($"Dequeued: {dequeneedName[i]}");
            }

            return dequeneedName;
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            throw new NotImplementedException();
        }

        public bool ASN02_StackPalindrome(string str)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
