using System;

namespace C_S_B_S{
    public class FlowerFunctions{
        public static Node<Flower> CreateFlowerList(){
            Flower f = null;
            Node<Flower> flowerList = null,  temp = null;

            Console.Write("[!] Flower Name: ");
            string name = Console.ReadLine();
            
            Console.Write("[!] Flower Color: ");
            string color = Console.ReadLine();
            
            Console.Write("[!] Flower Season: ");
            string season = Console.ReadLine();
            
            Console.Write("[!] Flower height: ");
            double height = double.Parse(Console.ReadLine());

            f = new Flower(name, height, color, season);
            flowerList = new Node<Flower>(f);

            for(int i=0; i<5; i++){
                Console.Write("[!] Flower Name: ");
                name = Console.ReadLine();
                
                Console.Write("[!] Flower Color: ");
                color = Console.ReadLine();
                
                Console.Write("[!] Flower Season: ");
                season = Console.ReadLine();
                
                Console.Write("[!] Flower height: ");
                height = double.Parse(Console.ReadLine());

                f = new Flower(name, height, color, season);
                temp = new Node<Flower>(f);
                flowerList = AddNode(flowerList, temp);
            }
            return flowerList;
        }

        public static Node<Flower> AddNode(Node<Flower> lst, Node<Flower> node){
            Node<Flower> p = lst;

            if (p == null){
                p = node;
            }else{
                while(p.HasNext())
                    p = p.GetNext();
                p.SetNext(node);
            }
            return p;
        }

        public static void SameColorSeason(Node<Flower> lst, string color){
            Node<Flower> p = lst;

            while(p != null){
                if (p.GetValue().GetColor() == color)
                    Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        public static void MostCommonSeason(Node<Flower> lst){
            int countFall = 0, countWinter = 0, countSpring = 0, countSummer = 0, maxNumber = 0;
            Node<Flower> p = lst;

            while(p != null){
                switch(p.GetValue().GetSeason()){
                    case "summer":
                        countSummer++;
                        break;
                    case "winter":
                        countWinter++;
                        break;
                    case "fall":
                        countFall++;
                        break;
                    case "spring":
                        countSpring++;
                        break;
                }
                p = p.GetNext();
            }

        maxNumber = Math.Max(countFall, Math.Max(countWinter, Math.Max(countSpring, countSummer)));

            if(maxNumber == countFall){Console.WriteLine("Fall");}
            if(maxNumber == countWinter){Console.WriteLine("Winter");}
            if(maxNumber == countSpring){Console.WriteLine("Spring");}
            if(maxNumber == countSummer){Console.WriteLine("Summer");}
        }
    }
}