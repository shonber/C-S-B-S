using System;

namespace cshrap
{
    public class MainFlower{
        public static Node<Flower> CreateFlowerList(){
            Flower f = null, f1 = null;
            Node<Flower> flowerList = null,  temp = flowerList;

            Console.Write("[!] Flower Name: ");
            string name = Console.ReadLine();
            
            Console.Write("[!] Flower Color: ");
            string color = Console.ReadLine();
            
            Console.Write("[!] Flower Season: ");
            string season = Console.ReadLine();
            
            Console.Write("[!] Flower height: ");
            double height = double.Parse(Console.ReadLine());

            f1 = new Flower(name, height, color, season);
            flowerList = new Node<Flower>(f1);

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

        public static Node<Flower> AddNode(Node<Flower> nodeList, Node<Flower> add){
            Node<Flower> head = nodeList;

            if (head == null){
                head = add;
            }else{
                while(head.HasNext())
                    head = head.GetNext();
                head.SetNext(add);
            }
            return head;
        }

        public static void SameColorSeason(Node<Flower> flowerList, string color){
            while(flowerList != null){
                if (flowerList.GetValue().GetColor() == color)
                    Console.WriteLine(flowerList.GetValue());
                flowerList = flowerList.GetNext();
            }
        }

        public static void MostFlowerSeason(Node<Flower> flowerList){
            int countFall = 0, countWinter = 0, countSpring = 0, countSummer = 0, maxNumber = 0;

            while(flowerList != null){
                switch(flowerList.GetValue().GetSeason()){
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
                flowerList = flowerList.GetNext();
            }

            maxNumber = Math.Max(countFall, Math.Max(countWinter, Math.Max(countSpring, countSummer)));

            if(maxNumber == countFall){Console.WriteLine("Fall");}
            if(maxNumber == countWinter){Console.WriteLine("Winter");}
            if(maxNumber == countSpring){Console.WriteLine("Spring");}
            if(maxNumber == countSummer){Console.WriteLine("Summer");}
        }
    }
}