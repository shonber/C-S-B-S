using System;

namespace cshrap
{
    public class Node<T>{
        private T value;
        private Node<T> next;

        public Node(T v){
            this.value = v;
            this.next = null;
        }

        public Node(T v, Node<T> n){
            this.value = v;
            this.next = n;
        }

        public T GetValue(){return this.value;}
        public Node<T> GetNext(){return this.next;}

        public void SetValue(T v){this.value = v;}
        public void SetNext(Node<T> n){this.next = n;}

        public bool HasNext(){
            if (this.next != null)
                return true;
            return false;
        }

        public override string ToString()
        {
                    if (this.next == null){
            return this.value + " --> " + "null";
        }
        return this.value + " --> " + this.next;
        }

    }
}