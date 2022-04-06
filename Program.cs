using System;

namespace Telephone_Directory_Application
{
    class Program
    {
        public static void Main(String[] args)
        {
            mainmenu();
            

        }



        static void mainmenu(){
            int choice = 0;
            SystemManager systemManager = new SystemManager();

            while (true)
            {
                Console.WriteLine("Choose a Operation\n********************\n1. Phone Number Save\n2. Phone Number Delete\n3. Phone Number Update\n4. Directory sort\n5. Search in Directory\n6. Exit");
                Console.Write("Your Choice : ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1){
                    systemManager.personAdd();
                    continue;
                }

                else if (choice == 2){
                    systemManager.personRemove();
                    if(systemManager.count != 0){
                        Console.Write("*Silmeyi sonlandırmak için : (1)\n*Yeniden denemek için : (2) ");
                        int decision = int.Parse(Console.ReadLine());
                        if(decision == 1)
                            break;
                        else if(decision == 2)
                            systemManager.personRemove();
                    }
                    continue;
                }

                else if(choice == 3){
                    systemManager.personUpdate();
                    if(systemManager.count_update != 0){
                        Console.Write("*Silmeyi sonlandırmak için : (1)\n*Yeniden denemek için : (2) ");
                        int decision1 = int.Parse(Console.ReadLine());
                        if(decision1 == 1)
                            break;
                        else if(decision1 == 2)
                            systemManager.personUpdate();
                    }
                    continue;


                }
                else if (choice == 4){
                    systemManager.guideSearch();
                    continue;

                }
                else if(choice == 5){
                    systemManager.search();
                    
                    continue;
                }
                else if(choice == 6)
                    break;

                else
                    Console.WriteLine("Something went wrong ... ");
                

            }
        }
    }

}