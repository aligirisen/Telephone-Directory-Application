namespace Telephone_Directory_Application
{fd
    public class Person : People
    {
        public string name;
        public string surname;
        public string number;
        public string a;

        


        
        public Person(string name, string surname, string number){
            this.name = name;
            this.surname = surname;
            this.number = number;
        }
        
        public string toString(){
            return "Name : "+this.name+"\n"+"Surname: "+this.surname+"\n"+"Phone Number : "+this.number;
        }
        

    }
}
