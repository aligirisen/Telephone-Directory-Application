using System; 

namespace Telephone_Directory_Application
{sdf
    class SystemManager : People
    {   
        public int count = 1;
        public int count_update = 1;

        public void personAdd(){
            Console.Write("Please Enter the Name : ");
            string name = Console.ReadLine();

            Console.Write("Please Enter the Surname : ");
            string surname = Console.ReadLine();

            Console.Write("Please Enter the Number : ");
            string number = Console.ReadLine();

            persons.Add(new Person(name,surname,number));

            Console.WriteLine("Person added successfully");
            

        }
        
        public void personRemove(){
            people();

            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını yada soyadını giriniz: ");
            string search = Console.ReadLine();
            

            for(int i =0; i<persons.Count;i++){
                if(persons[i].name == search || search == persons[i].surname){
                    Console.Write(persons[i]+"isimli kisiyi silmeyi onaylıyor musunuz ?(y/n) ");
                    string c = Console.ReadLine();
                    if(c == "y"){
                        Console.WriteLine(persons[i]+" başarıyla silindi...");
                        persons.RemoveAt(i);
                    }
                    else if(c == "n")
                        break;
                    
                    count = 0;
                    break;
                }
                else
                    count++;
            }
        }
        public void personUpdate(){
            people();

            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını yada soyadını giriniz: ");
            string search = Console.ReadLine();
            for(int i =0; i<persons.Count;i++){
                if(persons[i].name == search || search == persons[i].surname){
                    Console.WriteLine("Seçtiğiniz kişinin numarasını güncellemek istiyor musunuz ?(y/n) ");
                    string c = Console.ReadLine();
                    if(c == "y"){
                        Console.Write("Yeni numarayı giriniz : ");
                        string newNumber=Console.ReadLine();
                        persons[i].number= newNumber; 
                        Console.WriteLine(persons[i]+" güncellendi...");
                    }
                    else if(c == "n")
                        break;
                    
                    count_update = 0;
                    break;
                }
                else
                    count_update++;
            }

        }
         public void guideSearch(){

            people();
            
            for(int i=0;i<persons.Count;i++){
                Console.WriteLine("*******\nName : "+persons[i].name+"\nSurname : "+persons[i].surname+"\nNumber : "+persons[i].number);
            }

            Console.ReadKey();

        }

        public void search(){
            people();

            Console.WriteLine("İsim veya Sİsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için (2)");
            int choice1 = int.Parse(Console.ReadLine());

            if(choice1 == 1){
                Console.Write("Lütfen aramak istediğiniz kişinin adını yada soyadını giriniz: ");
                string search = Console.ReadLine();


                for(int i =0; i<persons.Count;i++){
                    if(persons[i].name == search || search == persons[i].surname){
                        Console.WriteLine("***************\nName : "+persons[i].name+"\nSurname : "+persons[i].surname+"\nNumber : "+persons[i].number);
                    }
                }
            }
            else if(choice1 == 2){
                for(int j = 0;j<persons.Count;j++){
                    if(persons[j].number.Equals(search))
                    Console.WriteLine("***************\nName : "+persons[j].name+"\nSurname : "+persons[j].surname+"\nNumber : "+persons[j].number);
                }

            }
        }
    }

}

        
        
    
